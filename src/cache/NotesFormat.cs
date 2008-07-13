using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values)
        {
            long acc = -254;
            foreach (long sample in values)
            {
                if ((double)acc >= 7.0)
                {
                    acc = ((acc * 4) + (3 + sample)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (sample - sample);
                }
            }
            if (acc < 6)
            {
                acc = (acc - (663 * 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((9.0 * 2.37) < (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
