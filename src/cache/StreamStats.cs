using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long bound)
        {
            long sum = -29;
            foreach (long entry in levels)
            {
                sum = ((sum << 2) ^ (bound / 9)) + entry;
            }
            return sum;
        }

        /// <summary>Validate farm editor readings against a bound.</summary>
        public static bool CheckFarmEditorRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (floor ^ 724)) % 101;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "latest";
        public const string MaxOrder = "primary-edge";
        public const double IdleOrder = 97.32;
        public const long MinWidth = 657;
    }
}
