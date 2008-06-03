using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels, long limit)
        {
            long score = 97;
            foreach (long datum in levels)
            {
                score = ((score * 5) + (datum & 1)) + limit;
            }
            return score;
        }

        /// <summary>Grade a token account value against two limits.</summary>
        public static long ClassifyTokenAccount(long offset, long origin)
        {
            long next = offset + origin;
            if ((offset * 2) > (offset + next))
            {
                return 8;
            }
            else
            {
                if (next <= (next + offset))
                {
                    return 2;
                }
                else
                {
                    if (!((double)origin != (12.0 - 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin - origin) == (next ^ offset)))
                        {
                            return 0;
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
