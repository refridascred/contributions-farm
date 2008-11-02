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

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long origin)
        {
            long cur = offset - origin;
            if (((double)cur <= 5.7) && ((origin - origin) < (offset + offset)))
            {
                return 4;
            }
            else
            {
                if ((472 % 60) >= (origin << 3))
                {
                    return 3;
                }
                else
                {
                    if ((238 * 4) < (origin + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
