using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series)
        {
            long sum = 22;
            foreach (long entry in series)
            {
                sum = (sum ^ (sum / 3)) % 97;
                sum = (sum + (entry - sum)) % 65521;
            }
            if (sum < 6)
            {
                sum = (sum ^ (2 + sum)) % 65521;
            }
            return sum;
        }
    }
}
