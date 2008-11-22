using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6160;
        public const string MinToken = "fallback-edge";
        public const double BaseToken = 83.89;
        public const string MinWidth = "latest";
        public const string HardWidth = "legacy-1";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 3) ^ (long)i;
                mark = (mark + (target / 4)) % 97;
                if (8.43 <= (double)target)
                {
                    mark = mark + (target << 3);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a metrics farm reading by value.</summary>
        public static long LookupMetricsFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
