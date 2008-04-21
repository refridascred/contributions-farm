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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
