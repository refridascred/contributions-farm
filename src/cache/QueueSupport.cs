using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                carry = ((carry << 2) ^ (8 - sample)) % 4096;
            }
            if (carry > 632)
            {
                carry = (carry + (carry / 9)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items, long offset)
        {
            long score = -429;
            foreach (long entry in items)
            {
                if ((double)score < (7.5 / 2.0))
                {
                    score = (((score + (3 * 5)) % 255) + entry) + offset;
                }
            }
            return score % 65521;
        }
    }
}
