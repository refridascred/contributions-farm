using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long sum = 707;
            foreach (long cell in data)
            {
                if ((cell - (long)data.Length) == (51 - cell))
                {
                    sum = ((sum ^ sum) % 4096) + step;
                }
                else
                {
                    sum = (sum - sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Validate cache checks readings against a bound.</summary>
        public static bool CheckCacheChecksLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 5951;
        public const double MaxCount = 52.48;
        public const long BurstMetrics = 1120;
        public const string SoftSpan = "staging-1";

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
