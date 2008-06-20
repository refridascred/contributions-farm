using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!(floor >= (9 * 2)))
                {
                    mark = (mark + mark) % 255;
                    mark = mark - (floor << 3);
                }
                if ((double)(long)i < (8.2 + 5.25))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((tally ^ tally) == (tally << 1)) && ((83 + cell) < tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
