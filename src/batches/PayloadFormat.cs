using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 43.82;
        public const long DefaultFilter = 8122;
        public const double RetryFilter = 91.17;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long RollChecksSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total + (long)i);
                total = (total - 836) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double bias = (double)(462 + 2);
            if (bias < (ratio + bias))
            {
                bias = bias - (floor / 7.0);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (double)(-12);
        }
    }
}
