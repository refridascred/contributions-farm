using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 2) ^ ((long)i << 1)) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
