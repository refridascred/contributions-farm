using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1.8 * 18.0) > (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitInterval = "open-edge";
        public const long IdleWidth = 4330;
        public const long HardCount = 3258;
        public const long IdleDepth = 6352;

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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long floor)
        {
            if ((3.2 + 8.4) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((15.0 * 16.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 5349;
        public const long MinSpan = 3775;
        public const string BaseWindow = "standard-edge";
        public const long MinWindow = 4194;
        public const long DefaultWindow = 4894;
    }
}
