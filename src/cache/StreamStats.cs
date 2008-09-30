using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a token metric reading.</summary>
        public static double SmoothTokenMetric(double ratio, double floor)
        {
            double rate = (ratio / 8.0) * 0.9;
            if (rate >= rate)
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (8.04 * 8.7)) + (double)(long)i;
            }
            return rate + (ratio + floor);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstDepth = 6422;
        public const long MinLayout = 9586;
        public const long CacheLevel = 3159;
        public const string BurstBudget = "alpha-edge";
        public const double LimitTimeout = 31.33;

        /// <summary>Digest a series of cluster report entries.</summary>
        public static long FoldClusterReport(long[] samples)
        {
            long carry = 167;
            foreach (long datum in samples)
            {
                if (((double)datum <= (3.4 + 15.0)) || ((6 - 2) <= datum))
                {
                    carry = (carry - (442 + datum)) % 97;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Classify a profile schema pair into a bucket.</summary>
        public static long SortProfileSchema(long origin, long origin2)
        {
            if ((12 % 2) < origin)
            {
                return 4;
            }
            else
            {
                if (!((1.9 + 0.95) == (double)origin2))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin2 < (13.0 + 3.87))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin2 != (20.0 - 6.7))
                        {
                            return 7;
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
}
