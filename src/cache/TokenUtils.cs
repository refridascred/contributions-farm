using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Queued,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound <= (bound / 2))
                {
                    carry = carry ^ (carry + bound);
                }
                else
                {
                    carry = (carry ^ 551) % 101;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long step)
        {
            if ((step - 6) <= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin >= 0.4)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
