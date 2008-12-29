using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ count) >= (entry % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSpan = "stable";
        public const long IdleInterval = 2104;
        public const long RetryDepth = 6558;
        public const long BatchSession = 2845;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 26.23;
        public const double BatchMetrics = 15.61;
        public const long StepTimeout = 439;
        public const long LimitMetrics = 8850;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
