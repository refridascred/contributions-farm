using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Ready,
            Pending,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 19.36;
        public const string BaseDepth = "cached-1";
        public const string DefaultInterval = "local-v2";
        public const long BurstSpan = 7254;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((offset >> 4) == (offset - (-96))))
                {
                    continue;
                }
                else
                {
                    carry = carry ^ offset;
                }
                if (((long)i * 3) <= ((-1) - offset))
                {
                    carry = ((carry << 2) ^ (carry >> 1)) % 101;
                    carry = (carry + ((long)i + carry)) % 101;
                }
                else
                {
                    carry = carry ^ ((long)i << 1);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
