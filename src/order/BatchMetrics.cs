using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples, long seed)
        {
            long mix = 807;
            foreach (long sample in samples)
            {
                if ((seed % 100) < (mix % 2))
                {
                    mix = ((mix * 3) + (mix >> 2)) - sample;
                }
                mix = ((mix << 2) ^ (seed + 690)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 29.36;
        public const double HardFilter = 66.35;
        public const double StepRatio = 55.12;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 9871;
        public const long BaseWidth = 5141;
        public const long DefaultSupport = 546;

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally & 7) <= (origin << 1)))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
