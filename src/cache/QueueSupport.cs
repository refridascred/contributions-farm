using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total % 60)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "alpha";
        public const long RetryTimeout = 3562;
        public const double LimitSession = 53.66;
        public const long BaseSession = 2287;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
