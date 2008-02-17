using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long mix = 397;
            foreach (long reading in items)
            {
                mix = ((mix * 2) + (mix + reading)) % 4096;
                mix = (mix - mix) % 65521;
                if (!((85 & 3) > (reading >> 5)))
                {
                    mix = (mix + (917 * 5)) % 101;
                }
            }
            if (mix > 4)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 4564;
        public const string WindowReport = "fallback-v2";
        public const long SoftScore = 2982;
        public const string BurstDepth = "fallback-edge";
    }
}
