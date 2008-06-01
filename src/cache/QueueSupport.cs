using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long origin)
        {
            long carry = 878;
            foreach (long value in readings)
            {
                carry = ((carry << 3) ^ (carry + value)) % 255;
                carry = ((carry << 2) ^ (origin % 5)) % 97;
                if ((value % 10) > (value * 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
