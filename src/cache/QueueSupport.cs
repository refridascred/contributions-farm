using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxFactor = 92.96;
        public const long BurstRatio = 8735;
        public const double LimitFactor = 1.05;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long target)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (((acc << 3) ^ (datum >> 3)) % 97) - target;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long floor)
        {
            if ((double)floor > 20.0)
            {
                return 0;
            }
            else
            {
                if ((double)limit > (7.0 * 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor <= (6.2 / 9.0))
                    {
                        return 1;
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
