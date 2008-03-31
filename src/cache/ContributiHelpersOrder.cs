using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a batch commits counter forward.</summary>
        public static long SeriesBatchCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score - score) - (long)i2;
                    score = (score + score) % 101;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
        }
    }
}
