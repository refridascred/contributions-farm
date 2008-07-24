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

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            New,
            Locked,
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

        /// <summary>Blend two farm report measurements.</summary>
        public static double AdjustFarmReport(double rate, double span)
        {
            double bias = (rate + 1.06) + span;
            if (bias < (double)305)
            {
                bias = bias - (bias - span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (rate * 5.66)) - (double)(long)i;
            }
            return bias + (rate / 5.0);
        }
    }
}
