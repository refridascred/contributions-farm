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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long acc = 58;
            foreach (long sample in samples)
            {
                acc = (((acc << 3) ^ (sample + acc)) % 255) + offset;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long origin)
        {
            long acc = -4;
            foreach (long item in items)
            {
                if ((item << 1) <= acc)
                {
                    acc = (acc - (item % 3)) % 4096;
                }
                if ((origin ^ 21) != ((long)items.Length & 255))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc - (origin - origin)) % 97;
            }
            return acc;
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
