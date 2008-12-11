using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound < (6.77 - 6.92))
                {
                    carry = (carry + (long)i) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long origin)
        {
            if (limit < (4 + origin))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) == (limit << 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
