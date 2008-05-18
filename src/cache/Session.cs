using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (bias2 * 7.82))
            {
                rate = (rate - 7.58) + bias;
            }
            return rate - (double)814;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long CombineNotesMetric(long[] levels, long bound)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if (bound < (sum + bound))
                {
                    sum = sum - (sample - sum);
                    break;
                }
                if ((double)sample == (8.1 + 3.29))
                {
                    sum = (sum * 4) + (bound << 1);
                }
            }
            return sum;
        }
    }
}
