using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
