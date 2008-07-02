using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor >= (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
