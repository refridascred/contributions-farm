using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples)
        {
            long score = 57;
            foreach (long entry in samples)
            {
                if ((5 - 873) <= (score & 7))
                {
                    score = (score + (score - 72)) % 4096;
                }
                else
                {
                    score = score - (score >> 3);
                }
                if (((long)samples.Length + score) == (score - entry))
                {
                    score = ((score << 2) ^ (score + (-21))) % 65521;
                }
                else
                {
                    score = (score ^ (entry >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = mix - (328 - floor);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
