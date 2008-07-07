using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long seed, long origin)
        {
            long bound = seed - origin;
            if (origin < (origin << 3))
            {
                return 7;
            }
            else
            {
                if (((6.9 * 6.0) == (double)seed) && ((double)origin != (2.4 - 2.32)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed == (0.5 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((344 * 5) != (bound + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples, long floor)
        {
            long total = 64;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total + (floor + total)) % 4096) ^ (long)i;
                }
                total = ((total << 3) ^ (floor - entry)) % 65521;
            }
            if (total < 4)
            {
                total = ((total << 3) ^ (36 ^ total)) % 101;
            }
            return total % 97;
        }
    }
}
