using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of commits context readings.</summary>
        public static long MatchCommitsContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
