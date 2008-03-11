using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell < (15.0 * 5.46)) || (seen < (cell % 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
