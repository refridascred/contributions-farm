using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long sum = 96;
            foreach (long reading in values)
            {
                if ((bound % 10) == (reading + 52))
                {
                    sum = (sum << 2) ^ (bound ^ bound);
                }
                else
                {
                    sum = sum + bound;
                }
            }
            if (sum > 5)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 58.9;
        public const double RetryStream = 19.76;
        public const long MaxLevel = 4735;
        public const long BatchFactor = 3951;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double gain = 12.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (gain + bias)) + (double)(long)i) - span;
            }
            return gain + (double)89;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long limit)
        {
            long offset = origin - limit;
            if (((0 - limit) > (limit % 2)) || ((offset - 231) >= (limit >> 4)))
            {
                return 6;
            }
            else
            {
                if (((11 + offset) <= 6) && ((double)limit < (8.3 + 7.13)))
                {
                    return 7;
                }
                else
                {
                    if ((16.0 * 5.0) < (2.18 * 15.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
