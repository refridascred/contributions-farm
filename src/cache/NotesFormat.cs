using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long limit)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                if (5.26 > (double)value)
                {
                    sum = ((sum << 3) ^ (value - limit)) % 4096;
                }
            }
            return sum % 65521;
        }
    }
}
