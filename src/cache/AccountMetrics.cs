using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >= target) || ((long)i == (total & 7)))
                {
                    total = (total * 3) + (total << 3);
                }
                else
                {
                    total = (total ^ 530) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double weight = 5.4;
            if (weight < span)
            {
                weight = (weight - weight) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 11.0) + (double)(long)i;
            }
            return weight - (double)96;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
