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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long sum = 398;
            foreach (long sample in readings)
            {
                sum = ((((sum * 2) + 945) % 1000) - sample) - step;
            }
            return sum % 1000;
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
