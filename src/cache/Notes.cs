using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 4816;
        public const long HardInterval = 406;
        public const long LimitDepth = 828;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (((seed - prev) != (seed ^ 50)) && ((-45) < (origin - prev)))
            {
                return 7;
            }
            else
            {
                if ((origin - seed) != (prev + seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed <= (9.3 - 4.6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Done,
            Idle,
        }
    }
}
