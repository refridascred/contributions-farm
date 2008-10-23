using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((0 * 5) <= (limit % 5))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
                mix = ((mix << 2) ^ (mix - (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen + seen) >= seen) && ((double)seen < (6.93 - 1.0)))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
