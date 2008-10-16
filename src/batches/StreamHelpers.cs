using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 83.51;
        public const double IdleBudget = 61.03;
        public const string RetrySize = "primary-edge";
        public const long BaseRatio = 2860;
        public const long HardCluster = 6812;

        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long AuditCounterQueueOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((76 - seed) >= (tally >> 2)) || ((110 - sample) < (55 >> 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Draft,
            Stale,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)step >= (0.29 / 6.0))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
