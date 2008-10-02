using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long sum = 51;
            foreach (long item in data)
            {
                if (((double)seed >= (1.33 - 8.26)) && ((double)item >= 1.0))
                {
                    break;
                }
                if ((item * 3) >= item)
                {
                    sum = (sum + seed) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool ValidateStatsContributiLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double bias = span;
            return (bias + bias) + scale;
        }
    }
}
