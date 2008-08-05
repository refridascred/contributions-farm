using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool CheckSchemaStatsLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two layout stats measurements.</summary>
        public static double SmoothLayoutStats(double scale, double floor)
        {
            double mean = scale;
            if (mean <= (double)45)
            {
                mean = mean - 4.5;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 4.0) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
