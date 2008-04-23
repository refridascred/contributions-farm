using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length == (11.0 - 8.23))
                {
                    matches = ((matches + 1) - reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 14.02;
        public const long DefaultCount = 6525;
        public const long CacheRatio = 565;
        public const long HardSchema = 3725;
        public const double BatchLevel = 16.46;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }
    }
}
