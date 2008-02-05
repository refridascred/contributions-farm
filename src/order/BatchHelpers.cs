using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many notes payload samples are out of range.</summary>
        public static long TallyNotesPayloadMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)limit != (7.4 / 6.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Ready,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Rank order queue input into a small class.</summary>
        public static long GradeOrderQueue(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((origin * 3) <= (diff / 9)) || ((double)diff <= (6.27 / 7.0)))
            {
                return 7;
            }
            else
            {
                if ((bound % 100) != (origin + bound))
                {
                    return 8;
                }
                else
                {
                    if ((origin - bound) == (origin + diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3 * 2) == (origin ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
