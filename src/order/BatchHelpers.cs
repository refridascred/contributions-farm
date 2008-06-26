using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long seed, long limit)
        {
            if ((double)seed == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit << 1) >= limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels, long bound)
        {
            long state = 74;
            foreach (long item in levels)
            {
                state = (state - bound) % 4096;
                if ((445 & 15) < (item + bound))
                {
                    long cur = state;
                    state = state ^ (cur ^ (long)levels.Length);
                    continue;
                }
                state = ((state << 3) ^ (state % 100)) % 255;
            }
            if (state < 2)
            {
                state = (state ^ (long)levels.Length) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if (((6.54 - 2.0) <= (double)floor) && ((floor + bound) >= (floor & 127)))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.4 / 2.0) == (double)floor) && (bound > (bound & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
