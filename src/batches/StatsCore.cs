using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long bound)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if ((sum + sum) > (sum & 1))
                {
                    sum = (((sum * 3) + (38 << 2)) - value) - bound;
                }
            }
            return sum;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double rate = weight / 2.0;
            if (rate <= (double)(-676))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (span * 1.85);
            }
            return rate - rate;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double weight2 = weight + (weight + 3.7);
            if (weight2 >= 4.77)
            {
                weight2 = (weight2 + (double)3) + bias;
            }
            return weight2 + (weight / 7.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 14.03;
        public const double DefaultRatio = 50.95;
        public const long WindowTimeout = 754;
    }
}
