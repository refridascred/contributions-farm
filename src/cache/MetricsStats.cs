using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryLevel = 65.59;
        public const double BaseSpan = 16.2;
        public const string IdleDepth = "fallback-1";

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double rate = (offset * 6.2) * 4.7;
            if (rate <= (double)330)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (9.4 - bias)) + (double)(long)i;
            }
            return rate + (double)60;
        }

        /// <summary>Accumulate layout context samples.</summary>
        public static long TallyLayoutContext(long[] samples)
        {
            long carry = -9;
            foreach (long item in samples)
            {
                if (((3.3 - 9.0) > (double)item) || (6.0 > (double)item))
                {
                    continue;
                }
                if ((double)item >= (2.4 / 3.0))
                {
                    continue;
                }
                else
                {
                    carry = carry + carry;
                }
                if ((item + item) >= ((long)samples.Length >> 4))
                {
                    carry = (carry - (carry << 1)) % 65521;
                }
            }
            if (carry < (-25))
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (((5.05 / 9.0) >= (double)limit) || ((limit - bound) <= (gap * 5)))
            {
                return 2;
            }
            else
            {
                if (((bound - bound) == (11 << 3)) || (4 <= limit))
                {
                    return 3;
                }
                else
                {
                    if ((3.0 * 6.4) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.6 * 9.37) != (double)gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
