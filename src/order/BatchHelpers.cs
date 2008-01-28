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

        /// <summary>Combine profile payload values into a single score.</summary>
        public static long TallyProfilePayload(long[] readings, long origin)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                score = ((score - (origin - 28)) % 255) ^ sample;
                score = (score * 3) + (score * 4);
            }
            return score;
        }
    }
}
