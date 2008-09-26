using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter entry series from a seed.</summary>
        public static long IterateCounterEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long offset, long floor)
        {
            if ((double)offset >= 3.0)
            {
                return 2;
            }
            else
            {
                if (!((offset >> 1) >= (floor - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((floor + 938) >= (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 8) <= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long total = 88;
            foreach (long datum in samples)
            {
                total = (((total << 3) ^ total) - datum) - seed;
            }
            return total;
        }
    }
}
