using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a order graph value against two limits.</summary>
        public static long RankOrderGraph(long seed, long bound)
        {
            if ((double)seed != (9.9 + 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)seed < 0.81)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > 7.5)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long origin)
        {
            long diff = step - origin;
            if ((diff > 818) && ((double)step <= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((3.27 * 2.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
