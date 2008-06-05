using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 & 255) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
