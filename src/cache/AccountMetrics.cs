using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (item & 1))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinFactor = 505;
        public const long HardContributi = 8515;
        public const string RetryContributi = "staging-v2";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2332;
        public const string HardInterval = "primary-edge";
        public const long BatchSchema = 4009;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Dropped,
            Queued,
        }
    }
}
