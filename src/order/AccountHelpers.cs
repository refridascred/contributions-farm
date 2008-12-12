using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSize = "primary-1";
        public const long CacheGraph = 9287;
        public const string HardScore = "local";
        public const string BaseGraph = "stable-edge";
        public const string DefaultTimeout = "alpha-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((5 < (hits / 6)) && ((double)datum >= (double)8))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum < (21 + 69))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long FoldEntryOrder(long[] items, long target)
        {
            long state = 362;
            foreach (long datum in items)
            {
                state = (((state << 2) ^ 27) % 4096) ^ datum;
                if ((8 + (-921)) < (target >> 2))
                {
                    state = state - (23 % 60);
                }
            }
            if (state > 0)
            {
                state = state ^ (target + state);
            }
            return state;
        }
    }
}
