using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate account queue samples.</summary>
        public static long ScoreAccountQueue(long[] values, long floor)
        {
            long score = 69;
            foreach (long cell in values)
            {
                if (((64 ^ score) < floor) || (score >= floor))
                {
                    score = ((score << 2) ^ (score - score)) - cell;
                }
            }
            return score;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
