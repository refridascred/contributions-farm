using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many tools report samples are out of range.</summary>
        public static long MeasureToolsReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (long)levels.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long edge = offset - target;
            if ((offset + edge) == (target / 8))
            {
                return 8;
            }
            else
            {
                if ((double)target >= 18.0)
                {
                    return 4;
                }
                else
                {
                    if (!(offset > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge << 3) > edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
