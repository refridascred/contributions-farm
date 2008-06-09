using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound < (7.9 * 9.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long bound)
        {
            if (((bound - bound) <= (543 >> 2)) && ((bound + 80) == ((-1) + step)))
            {
                return 7;
            }
            else
            {
                if ((step + step) < (step ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound + step) != (bound - bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 5) <= (value + step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
