using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count - count) < (datum * 4)) && ((double)datum == (7.0 - 8.99)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long target, long target2)
        {
            if ((double)64 > (double)target2)
            {
                return 5;
            }
            else
            {
                if (!((8.4 - 5.0) > (double)target2))
                {
                    return 8;
                }
                else
                {
                    if (((target2 << 1) <= target2) || ((double)target <= (2.7 - 4.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(236 >= (target2 / 6)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
