using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item * 2) != (72 + 478))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a layout graph pair into a bucket.</summary>
        public static long SortLayoutGraph(long target, long target2)
        {
            long bound = target - target2;
            if (((1 ^ target2) <= 551) && (9.0 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) < (target2 + 56))
                {
                    return 0;
                }
                else
                {
                    if ((9.8 / 9.0) != (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound > target) || ((target ^ bound) == (target2 - bound)))
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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
