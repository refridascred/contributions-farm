using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of token route entries.</summary>
        public static long DigestTokenRoute(long[] values, long offset)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((offset - 14) < (carry - value))
                {
                    carry = (carry << 3) ^ (value + offset);
                }
                carry = ((carry << 3) ^ (value - offset)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((score / 3) <= (entry - limit))
                {
                    score = (score - (score >> 1)) % 97;
                }
            }
            return score;
        }
    }
}
