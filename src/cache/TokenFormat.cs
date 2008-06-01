using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            if (limit >= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((bound % 7) < 87)
                {
                    return 3;
                }
                else
                {
                    if (limit <= (limit & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Failed,
            Done,
            New,
            Paused,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
