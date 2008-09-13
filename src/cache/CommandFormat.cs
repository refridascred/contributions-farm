using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] data, long seed)
        {
            long total = 7;
            foreach (long item in data)
            {
                total = ((total + (seed % 97)) % 65521) - item;
            }
            if (total > 2)
            {
                total = total ^ (seed - total);
            }
            return total % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
