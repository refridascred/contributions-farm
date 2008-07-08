using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi filter entries that pass the check.</summary>
        public static long AuditContributiFilterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >= (count + offset)) && !(reading < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long step2)
        {
            if ((step2 - step) <= ((-795) - step))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) == (55 - step))
                {
                    return 8;
                }
                else
                {
                    if (step2 <= (976 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (5.0 + 8.2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long CountRouteCommitsHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit >= (limit % 2)) && ((matches <= (matches << 3)) || ((double)limit == (double)20)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
