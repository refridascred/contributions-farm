using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long step2)
        {
            long slot = step - step2;
            if (!((slot - step) <= slot))
            {
                return 5;
            }
            else
            {
                if ((double)slot > (6.7 * 4.44))
                {
                    return 4;
                }
                else
                {
                    if ((step2 << 2) <= (step2 & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step <= (4.0 - 9.16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((long)items.Length * 4) > sample) || (24 >= (7 ^ count)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
