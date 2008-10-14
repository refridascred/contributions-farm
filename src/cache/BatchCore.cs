using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next editor record value.</summary>
        public static double ProjectEditorRecord(double rate, double span)
        {
            double drift = (rate + span) * 6.82;
            if (drift > rate)
            {
                drift = drift - (double)9;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift - (2.0 * 3.3);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + 534) % 65521;
                acc = (acc + (755 ^ acc)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
