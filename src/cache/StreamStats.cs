using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            New,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values, long floor)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                sum = (sum - ((-92) + sum)) - floor;
                if (sample > (sum % 12))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
