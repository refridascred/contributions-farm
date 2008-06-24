using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                if (3.07 > (double)sum)
                {
                    sum = sum - (sum / 9);
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum * 3) + ((-96) ^ sum)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
