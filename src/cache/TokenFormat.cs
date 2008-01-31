using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long total = 59;
            foreach (long item in levels)
            {
                if ((item <= (total + item)) || ((double)total > (2.0 + 0.2)))
                {
                    total = (total ^ (origin & 255)) % 255;
                }
                else
                {
                    total = (total + (28 + item)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Ready,
            Queued,
            Paused,
            Failed,
        }
    }
}
