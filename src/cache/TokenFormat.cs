using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((seed * 4) < (seed + entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
