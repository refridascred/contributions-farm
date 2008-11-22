using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item > (offset >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double drift = offset;
            if (drift < (double)5)
            {
                drift = drift - (drift - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (rate * 8.12);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepDepth = 9.79;
        public const long MinLayout = 6736;
        public const long BatchScore = 3758;
        public const long DefaultWidth = 8320;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Done,
            Retry,
            Active,
            Queued,
        }
    }
}
