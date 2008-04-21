using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = sum + (sum << 3);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long floor)
        {
            long bound = step + floor;
            if (floor < (390 ^ bound))
            {
                return 7;
            }
            else
            {
                if ((923 - floor) < (floor << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (double)step)
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
