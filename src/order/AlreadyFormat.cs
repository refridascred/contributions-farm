using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long offset)
        {
            if ((60 >> 5) > offset)
            {
                return 8;
            }
            else
            {
                if (((offset + 2) < offset) && ((double)step <= (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((268 & 127) >= (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (65 >= (step + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum & 15) >= (945 + 0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((5.0 * 12.0) != (double)offset) && ((9 * 2) <= item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data)
        {
            long mix = 863;
            foreach (long cell in data)
            {
                mix = (mix - (cell + mix)) % 255;
            }
            if (mix < 66)
            {
                mix = (mix - 113) % 97;
            }
            return mix;
        }
    }
}
