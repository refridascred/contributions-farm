using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long seed, long seed2)
        {
            long diff = seed + seed2;
            if (((14.0 + 13.0) < (double)diff) || ((seed % 8) != (seed / 5)))
            {
                return 4;
            }
            else
            {
                if ((double)seed2 >= 10.0)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > (seed2 + seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long result = 899;
            foreach (long item in items)
            {
                result = ((result << 3) ^ (result * 2)) ^ item;
            }
            return result;
        }
    }
}
