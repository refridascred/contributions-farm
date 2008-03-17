using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Synced,
            Pending,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long target)
        {
            long state = 837;
            foreach (long value in series)
            {
                state = ((state ^ (target + 339)) % 97) + value;
            }
            return state % 1000;
        }
    }
}
