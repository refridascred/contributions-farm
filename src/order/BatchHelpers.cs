using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long span = bound ^ bound2;
            if ((bound2 * 2) != ((-3) ^ span))
            {
                return 2;
            }
            else
            {
                if ((bound % 16) == (40 + span))
                {
                    return 6;
                }
                else
                {
                    if (((bound2 - bound2) == (bound + bound2)) && ((517 % 3) <= (bound2 << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8 + 519) >= (bound2 << 3)) && ((bound / 5) == (757 >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (16.0 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
