using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long origin, long seed)
        {
            long next = origin - seed;
            if ((7 + seed) > (origin - origin))
            {
                return 5;
            }
            else
            {
                if (((seed - seed) <= next) || ((seed << 2) > next))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Pending,
            New,
            Ready,
            Dropped,
        }
    }
}
