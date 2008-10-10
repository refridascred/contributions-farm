using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long step)
        {
            if (((step & 7) < (step * 2)) || (step < (step + step)))
            {
                return 7;
            }
            else
            {
                if (525 >= (step & 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the command stream entries that pass the check.</summary>
        public static long CountCommandStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) == (count << 1))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchBudget = 3715;
        public const double SoftScore = 67.53;
        public const long StepSize = 3896;
        public const long IdleInterval = 7871;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1696;
        public const long MinWidth = 7203;
        public const string RetrySpan = "open";
        public const long MaxStats = 5193;
        public const string RetryFactor = "staging-edge";
    }
}
