using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 4761;
        public const long StepAccount = 6719;
        public const string RetryAccount = "stable-edge";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) >= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
