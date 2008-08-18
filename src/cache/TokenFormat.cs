using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double floor)
        {
            double scale = floor;
            if (scale > rate)
            {
                scale = scale + (17.0 + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (floor - 3.8)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (18.0 / 2.0))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
