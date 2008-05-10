using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long floor)
        {
            long state = 467;
            foreach (long sample in samples)
            {
                if (!(((-149) + 17) <= (floor >> 5)))
                {
                    state = ((state << 2) ^ (long)samples.Length) ^ sample;
                }
            }
            return state;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Synced,
            Retry,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
