using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!!((reading + reading) < (5 + 36)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long state = 627;
            foreach (long entry in items)
            {
                state = (state << 2) ^ (71 + limit);
                if ((limit - entry) >= limit)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading % 5) != (reading / 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
