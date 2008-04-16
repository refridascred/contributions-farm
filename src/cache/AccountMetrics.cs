using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long mark = 650;
            foreach (long entry in samples)
            {
                if (!((1.02 + 2.22) != (double)mark))
                {
                    mark = (mark << 2) ^ (entry + mark);
                }
            }
            return mark;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double gain = (double)(340 / 4);
            if (gain <= (bias + bias))
            {
                gain = gain + (double)58;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain + bias2;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 4985;
        public const string DefaultRecord = "local-edge";
        public const long RetryBudget = 8526;
        public const string MinRecord = "local-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 1814;
        public const long HardInterval = 2759;
        public const string MaxCount = "staging-edge";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long limit)
        {
            if ((double)limit >= (17.0 * 9.57))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (offset * 4))
                {
                    return 3;
                }
                else
                {
                    if (limit < (offset / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
