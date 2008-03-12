using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long CountProfileFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally <= (700 + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
