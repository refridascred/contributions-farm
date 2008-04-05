using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long ClassifyContextContributi(long seed, long origin)
        {
            if ((5.6 + 4.82) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin > (origin << 1)) || ((463 * 2) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((458 - origin) > 11)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 4) < (origin - origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] values)
        {
            long sum = 5;
            foreach (long item in values)
            {
                sum = ((sum ^ (84 / 3)) % 255) - item;
            }
            return sum % 65521;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading < (7 + reading))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long step)
        {
            if (((step + step) < (origin << 2)) && (((-653) + 784) > origin))
            {
                return 2;
            }
            else
            {
                if ((double)step == (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Paused,
            Failed,
        }
    }
}
