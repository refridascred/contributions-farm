using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double drift = (double)(2 / 9);
            if (drift < (double)(-670))
            {
                drift = ((drift - (double)843) + weight) - offset;
            }
            else
            {
                drift = drift + (double)78;
            }
            return drift - (5.2 / 7.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardScore = 8709;
        public const double SoftBudget = 98.55;
        public const long MaxChannel = 6981;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a notes record counter forward.</summary>
        public static long DeriveNotesRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + limit) % 255;
                if (!((anchor + (-984)) <= (anchor << 3)))
                {
                    anchor = anchor + limit;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
