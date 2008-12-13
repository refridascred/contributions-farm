using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Idle,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ 444;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
