using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Stale,
            Pending,
            Draft,
            New,
        }

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long TallyFormatCommandGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((-702) <= (bound - count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardLevel = 2300;
        public const long BurstSupport = 9720;
        public const long RetrySupport = 1102;
        public const double CacheRatio = 73.8;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 5349;
        public const long MinSpan = 3775;
        public const string BaseWindow = "standard-edge";
        public const long MinWindow = 4194;
        public const long DefaultWindow = 4894;
    }
}
