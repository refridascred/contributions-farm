using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Rank already notes input into a small class.</summary>
        public static long SortAlreadyNotes(long floor, long floor2)
        {
            long step = floor - floor2;
            if (((double)981 < (double)floor) && ((double)floor2 <= (2.95 - 8.2)))
            {
                return 8;
            }
            else
            {
                if (floor2 > (step & 31))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches + (long)samples.Length) <= (matches - value)) && ((value >> 1) != (matches & 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Pending,
            Stale,
            Paused,
        }
    }
}
