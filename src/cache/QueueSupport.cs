using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a record command value against two limits.</summary>
        public static long RankRecordCommand(long target, long offset)
        {
            if ((445 + (-27)) < offset)
            {
                return 2;
            }
            else
            {
                if (((-69) >> 1) == (target * 4))
                {
                    return 6;
                }
                else
                {
                    if (((target - offset) > (offset % 5)) && ((offset - target) <= (772 & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target == (6.43 * 6.19))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches & 63) < matches) || ((matches >= (matches & 3)) || ((entry + matches) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
