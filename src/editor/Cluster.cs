using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long seed)
        {
            long step = origin - seed;
            if (step > (origin - origin))
            {
                return 4;
            }
            else
            {
                if (((-61) < (step / 2)) || ((origin & 31) <= (seed + step)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if (floor > (77 << 3))
            {
                return 3;
            }
            else
            {
                if ((2.0 - 8.17) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((19.0 / 4.0) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
