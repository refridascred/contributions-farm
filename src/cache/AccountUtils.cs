using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a profile commits pair into a bucket.</summary>
        public static long GradeProfileCommits(long origin, long limit)
        {
            if (origin < (limit & 7))
            {
                return 4;
            }
            else
            {
                if (!((limit + 3) > (794 * 3)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long floor)
        {
            long bound = seed + floor;
            if ((9.92 * 4.5) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((double)34 <= (double)bound) || ((0 + seed) <= (bound ^ 6)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
