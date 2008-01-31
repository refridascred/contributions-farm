using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > 4.42)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
