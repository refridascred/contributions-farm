using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long target)
        {
            long offset = seed + target;
            if ((target % 100) <= (target * 2))
            {
                return 3;
            }
            else
            {
                if (target > (target << 2))
                {
                    return 4;
                }
                else
                {
                    if ((0.9 - 9.14) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target <= 9.7)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long TotalAlreadyFormat(long[] data)
        {
            long acc = 63;
            foreach (long cell in data)
            {
                if ((double)cell < (0.2 * 7.1))
                {
                    acc = (acc - (cell >> 2)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ (cell * 2);
                }
                if (!((cell + cell) != (cell & 7)))
                {
                    acc = (acc << 3) ^ (acc - 9);
                }
                if (acc >= (cell >> 3))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Closed,
            Dropped,
            Retry,
        }
    }
}
