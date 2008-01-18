using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a session queue counter forward.</summary>
        public static long RollSessionQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((20.0 * 7.79) < (double)(long)i)
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor - (anchor / 2)) % 101;
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 4096;
                }
                anchor = anchor + (0 - 8);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data)
        {
            long total = 76;
            foreach (long sample in data)
            {
                total = ((total * 3) + (total & 15)) % 255;
                if (!((sample * 5) == (sample >> 2)))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total - (total + total);
            }
            return total % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long limit)
        {
            long offset = seed + limit;
            if ((limit / 4) == (offset + 281))
            {
                return 1;
            }
            else
            {
                if ((double)offset > 7.6)
                {
                    return 6;
                }
                else
                {
                    if ((-277) <= (seed * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
