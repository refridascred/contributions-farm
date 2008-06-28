using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            if ((89 << 1) >= (floor2 % 12))
            {
                return 8;
            }
            else
            {
                if ((656 << 1) <= (floor ^ floor))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long origin)
        {
            if ((double)origin > 2.0)
            {
                return 7;
            }
            else
            {
                if (limit >= (origin * 3))
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit > (14.0 + 9.8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor + (anchor - (long)i)) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
