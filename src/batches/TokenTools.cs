using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long acc = 14;
            foreach (long value in levels)
            {
                if ((2.9 - 3.2) <= (double)value)
                {
                    acc = (acc ^ (value + (long)levels.Length)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = carry ^ (carry + cell);
            }
            return carry;
        }
    }
}
