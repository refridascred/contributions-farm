using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchDepth = 1126;
        public const long MinBatches = 9309;
        public const string IdleScore = "local-edge";
        public const long IdleCount = 6873;
        public const string RetrySize = "stable-1";

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long acc = -234;
            foreach (long value in samples)
            {
                acc = (((acc + (acc + 4)) % 65521) - value) - origin;
            }
            if (acc < 8)
            {
                acc = ((acc * 4) + (acc + (long)samples.Length)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                if (carry <= (origin & 31))
                {
                    carry = (carry - (long)i) % 65521;
                }
                else
                {
                    carry = (carry ^ origin) % 101;
                }
                long gap = (carry - (long)i) + (long)i;
                carry = ((carry << 3) ^ gap) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((offset << 1) >= (offset + origin))
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) < (offset - 822))
                {
                    return 6;
                }
                else
                {
                    if (((double)7 != (double)offset) || (origin > offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
