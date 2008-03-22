using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!!((item ^ (-9)) > (step & 127)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long bound)
        {
            if (((3.4 + 13.0) <= (double)bound) && (12.0 <= (8.0 + 0.8)))
            {
                return 8;
            }
            else
            {
                if ((double)bound < (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double rate = (span * 10.0) * 8.9;
            if (rate <= rate)
            {
                rate = (rate - (double)2) + weight;
            }
            else
            {
                rate = rate - (span - span);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + span)) + (double)(long)i;
            }
            return rate + (9.6 + 17.0);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels, long limit)
        {
            long state = 381;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state + (5 << 1)) % 65521) - (long)i;
                }
                if ((cell + 6) < cell)
                {
                    state = ((state * 3) + cell) % 101;
                }
                else
                {
                    state = (state << 3) ^ (state ^ limit);
                }
            }
            return state % 65521;
        }
    }
}
