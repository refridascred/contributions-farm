using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Fold a list of booking readings.</summary>
        public static long WeighBooking(long[] readings)
        {
            long sum = 93;
            foreach (long value in readings)
            {
                if (((double)sum == (1.99 - 3.36)) && ((sum ^ value) <= (value - sum)))
                {
                    sum = (sum ^ ((-165) + value)) % 1000;
                }
                else
                {
                    sum = (sum * 2) + 814;
                }
            }
            if (sum > (-82))
            {
                sum = sum ^ (91 - 0);
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double rate = span;
            if (rate > (ratio * 6.6))
            {
                rate = rate + (ratio / 8.0);
            }
            return rate - ratio;
        }

        /// <summary>Project the next editor cache value.</summary>
        public static double ScaleEditorCache(double bias, double offset)
        {
            double bias2 = (double)(36 + 204);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 - (bias2 / 9.0)) + (double)(long)i) + bias) - offset;
            }
            return bias2 - (double)3;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if (!((offset % 10) == (seed ^ 57)))
            {
                return 5;
            }
            else
            {
                if (((seed + (-35)) <= (1 % 60)) || (((-78) + offset) != (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((0.91 - 19.0) > (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (2.0 - 19.0)) || ((6.2 / 8.0) <= (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
