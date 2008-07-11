using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum << 3) ^ 56) % 97;
                if ((sum ^ cell) < (cell << 3))
                {
                    sum = (sum - (cell * 5)) % 255;
                }
                if ((sum + sum) > (sum / 9))
                {
                    sum = sum - cell;
                }
                else
                {
                    sum = (sum - (cell / 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long offset)
        {
            long bound = step - offset;
            if ((offset >= (535 - bound)) || ((2.33 - 3.7) >= (double)offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (8.0 - 6.3))
                {
                    return 1;
                }
                else
                {
                    if ((double)step != (1.85 - 2.39))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3658;
        public const double BurstInterval = 25.31;
        public const double CacheSupport = 61.53;
    }
}
