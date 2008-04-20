using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= 0.48)
            {
                mean = (mean - (bias / 2.0)) + ratio;
            }
            return mean - (bias / 8.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy-1";
        public const double BaseTimeout = 55.77;
        public const long WindowReport = 8245;
    }
}
