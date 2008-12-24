using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell >> 1) >= 0) || ((cell % 10) != (30 % 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (floor * 9.45))
            {
                mean = mean + (double)13;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - (floor - floor);
        }
    }
}
