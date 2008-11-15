using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Locked,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (span - bias)) + (double)(long)i;
            }
            return gain + (8.35 * 15.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 1086;
        public const double MaxEntry = 80.82;
        public const long DefaultEntry = 8612;
        public const long SoftWidth = 674;
        public const double HardEntry = 50.77;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((62 - value) == (13 * 2))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
