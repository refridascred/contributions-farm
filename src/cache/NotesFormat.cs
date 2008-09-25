using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long mix = 631;
            foreach (long datum in levels)
            {
                mix = (mix + datum) % 101;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (2.56 > (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound & 15) <= (bound / 6))
            {
                return 8;
            }
            else
            {
                if ((floor - bound2) == (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 61) != (bound - bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 5) <= bound2)
                        {
                            return 5;
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
