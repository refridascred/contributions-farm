using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                if ((reading + (-56)) != (5 & 15))
                {
                    mix = (mix << 3) ^ (reading << 3);
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
                mix = mix + mix;
            }
            if (mix < 498)
            {
                mix = (mix << 3) ^ (mix % 10);
            }
            return mix % 1000;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics account readings.</summary>
        public static long CompareMetricsAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
