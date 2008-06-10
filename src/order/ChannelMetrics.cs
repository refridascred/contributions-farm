using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + ((long)i + mix)) % 1000;
                mix = mix + seed;
                if (seed < (mix - seed))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long acc = 44;
            foreach (long sample in values)
            {
                if ((double)acc < (11.0 + 1.0))
                {
                    acc = ((acc ^ (sample ^ sample)) % 4096) - limit;
                }
                else
                {
                    acc = (acc * 5) + 3;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell * 2) > (target - target)) || (((double)target == (6.94 + 0.58)) && ((cell % 5) >= (cell & 63))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
