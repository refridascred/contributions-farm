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

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long origin2)
        {
            if ((origin & 63) < (origin + origin2))
            {
                return 2;
            }
            else
            {
                if ((double)origin2 >= 5.0)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
