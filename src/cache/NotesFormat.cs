using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (sample / 9))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long bound = seed ^ limit;
            if (bound <= (1 + bound))
            {
                return 2;
            }
            else
            {
                if (bound > (308 % 12))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 / 7.0) >= (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches * 5) < value) && (((double)value <= 20.0) && ((6.9 + 1.16) != (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
