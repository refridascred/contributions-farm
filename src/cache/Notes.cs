using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings)
        {
            long total = 80;
            foreach (long reading in readings)
            {
                if (((9.0 - 8.5) == (double)(long)readings.Length) || ((total + total) == (reading << 3)))
                {
                    total = total ^ (total + total);
                }
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 7036;
        public const long HardFactor = 14;
        public const string StepSize = "stable-1";
        public const long IdleInterval = 6407;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Active,
            New,
            Retry,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
