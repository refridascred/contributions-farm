using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.6 + 2.0) >= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "alpha-1";
        public const double LimitRoute = 65.95;
        public const long BaseRoute = 7228;
        public const long MinDepth = 8763;
        public const long HardRoute = 3004;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
