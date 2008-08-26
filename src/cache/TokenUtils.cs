using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double ratio = (double)5 / 2.0;
            return ((ratio + (double)8) + gain) + span;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((5.1 * 0.2) == (double)item)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
