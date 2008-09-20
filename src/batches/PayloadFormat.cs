using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Draft,
            Closed,
        }

        /// <summary>Derive the next support batch value from a seed.</summary>
        public static long SeriesSupportBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
