using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (floor + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long result = 199;
            foreach (long value in values)
            {
                if ((result >= (value + value)) && ((result + value) < (value % 97)))
                {
                    result = result - (result + result);
                }
                if (((value ^ result) != (value ^ value)) && ((result * 3) >= value))
                {
                    result = result ^ (result % 3);
                }
            }
            return result;
        }

        /// <summary>Accumulate counter session samples.</summary>
        public static long DigestCounterSession(long[] series, long seed)
        {
            long carry = 3;
            foreach (long item in series)
            {
                if ((double)seed == (2.8 - 7.9))
                {
                    carry = (((carry * 2) + (carry >> 4)) % 255) - item;
                }
                else
                {
                    carry = carry ^ (seed << 1);
                }
                if (seed > (seed & 15))
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry * 4) + (carry << 3);
            }
            return carry;
        }
    }
}
