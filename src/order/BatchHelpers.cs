using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                long matches = (origin ^ origin) + (origin ^ score);
                score = ((score << 2) ^ ((long)i * 4)) % 255;
                score = (score << 2) ^ (matches / 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Failed,
            Closed,
            Dropped,
        }
    }
}
