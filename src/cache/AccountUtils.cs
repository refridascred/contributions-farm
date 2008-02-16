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

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + (bound - sum);
                sum = ((sum << 3) ^ (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
