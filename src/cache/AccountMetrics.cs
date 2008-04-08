using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((limit + (-29)) >= datum) || ((5.38 * 1.4) == (double)datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
