using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples, long bound)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                result = (result * 4) + (cell - bound);
                result = ((result * 2) + result) % 65521;
                if ((6.3 * 12.0) == (double)cell)
                {
                    result = ((result << 3) ^ 75) % 1000;
                }
            }
            if (result < 1)
            {
                result = result - (7 % 100);
            }
            return result;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Audit checks filter readings against a rule.</summary>
        public static long CountChecksFilterGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - hits) < (hits % 5))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 5.28;
        public const double BaseSupport = 62.69;
        public const long HardSupport = 1986;
        public const double StepRatio = 14.81;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
