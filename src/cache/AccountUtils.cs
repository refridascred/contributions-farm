using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a graph contributi reading.</summary>
        public static double ProjectGraphContributi(double bias, double span)
        {
            double gain = (double)(275 ^ 499);
            if (gain < (double)0)
            {
                gain = ((gain + gain) - bias) - span;
            }
            return gain + gain;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long limit)
        {
            if ((17.0 * 0.43) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit << 3) != (limit / 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
