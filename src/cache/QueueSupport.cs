using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a token queue counter forward.</summary>
        public static long IterateTokenQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + seed;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long limit)
        {
            if ((limit > (target & 15)) && (limit <= target))
            {
                return 0;
            }
            else
            {
                if ((double)target > (7.0 - 5.2))
                {
                    return 2;
                }
                else
                {
                    if (((limit + target) == (3 << 3)) || (limit >= (target * 3)))
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

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
