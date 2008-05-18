using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long origin)
        {
            long step = seed + origin;
            if ((399 ^ origin) == (seed % 97))
            {
                return 6;
            }
            else
            {
                if (((684 + step) < (origin ^ origin)) || ((34 << 2) == (step + step)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long target)
        {
            long edge = origin + target;
            if ((double)edge <= (9.4 + 1.0))
            {
                return 4;
            }
            else
            {
                if (((8 ^ origin) < (target + target)) && ((9 - 762) < (target + origin)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long limit)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                carry = ((carry - (entry & 7)) % 97) + limit;
            }
            return carry;
        }
    }
}
