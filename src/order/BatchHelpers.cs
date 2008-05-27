using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
