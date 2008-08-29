using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long acc = 887;
            foreach (long cell in readings)
            {
                acc = ((acc + (acc & 255)) ^ cell) - offset;
            }
            if (acc < 879)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Rank filter commits input into a small class.</summary>
        public static long ClassifyFilterCommits(long offset, long floor)
        {
            long cur = offset - floor;
            if (offset >= (cur * 2))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 4.0) > (double)cur)
                {
                    return 6;
                }
                else
                {
                    if (((2 ^ offset) < offset) || ((double)floor > (9.07 + 1.2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + floor) == (floor - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result + bound);
                result = (result * 3) + ((long)i - result);
                result = (result + (result << 3)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
