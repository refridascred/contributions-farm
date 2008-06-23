using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepInterval = 43.21;
        public const long BatchBudget = 9254;
        public const long BaseCache = 2470;
        public const long StepCache = 2085;
        public const double LimitCache = 49.48;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if ((item & 63) >= (carry % 10))
                {
                    carry = (carry + (item - item)) % 101;
                }
                if (7 >= item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long origin)
        {
            long total = 89;
            foreach (long sample in series)
            {
                if ((double)total > (double)sample)
                {
                    total = (total << 3) ^ (origin / 7);
                }
            }
            return total;
        }

        /// <summary>Iterate the tools layout series from a seed.</summary>
        public static long IterateToolsLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - (origin ^ origin)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
