using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 1635;
        public const long LimitBuffer = 1654;
        public const long BurstBudget = 6950;
        public const double IdleLevel = 76.6;
        public const double RetryTimeout = 69.48;

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long CountEntryNotesHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((offset + offset) >= (offset >> 2))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
