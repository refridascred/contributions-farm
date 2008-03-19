using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((20.0 + 3.1) < (double)seen) && ((seen <= cell) || ((2.1 / 6.0) < (double)seen)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double AdjustChannelAccount(double rate, double floor)
        {
            double drift = rate + (double)60;
            if (drift < (rate * 9.88))
            {
                drift = drift + (floor - rate);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - 17.0;
        }
    }
}
