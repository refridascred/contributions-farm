using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((double)datum > (12.0 * 2.1))
                {
                    mix = mix - (datum >> 3);
                }
                else
                {
                    mix = mix - (datum + 9);
                }
            }
            if (mix < 187)
            {
                mix = (mix + (6 / 2)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double ratio = (double)(6 + 954);
            if (ratio < (bias * 5.54))
            {
                ratio = ratio - (bias / 3.0);
            }
            else
            {
                ratio = ratio - (gain - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (3.1 * 14.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits > (1 & 255))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Draft,
            Ready,
            Paused,
        }
    }
}
