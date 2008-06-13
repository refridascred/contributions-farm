using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples)
        {
            long carry = 161;
            foreach (long value in samples)
            {
                if (354 <= ((-3) ^ value))
                {
                    carry = carry - value;
                }
            }
            if (carry < 856)
            {
                carry = (carry ^ (carry / 2)) % 101;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 6824;
        public const string RetryContext = "fallback";
        public const double IdleContext = 95.08;
        public const long MaxFactor = 7171;
        public const long RetryRatio = 7291;

        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ProjectMetricsCommits(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }
    }
}
