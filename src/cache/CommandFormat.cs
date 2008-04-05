using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)limit >= 7.3)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Stale,
            Locked,
            Retry,
            Queued,
        }
    }
}
