using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count & 3) < count)
                {
                    count = ((count + 1) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many window format samples are out of range.</summary>
        public static long CountWindowFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((tally + tally) > sample) && ((tally - 3) > 536))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            if ((double)origin > (2.0 * 3.5))
            {
                return 7;
            }
            else
            {
                if ((origin2 ^ origin2) > (origin2 - origin))
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
