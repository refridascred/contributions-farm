using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long origin)
        {
            long score = 98;
            foreach (long sample in items)
            {
                if ((5.1 < (double)origin) || ((double)sample <= 7.4))
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double scale = (floor / 3.0) * 9.8;
            if (scale < (double)6)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - 3.4;
        }

        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long AuditChannelNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) != (target - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
