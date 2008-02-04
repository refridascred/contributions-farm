using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                anchor = anchor ^ datum;
            }
            if (anchor < 8)
            {
                anchor = (anchor * 4) + (anchor / 2);
            }
            return anchor;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long step)
        {
            if (limit <= (limit + step))
            {
                return 8;
            }
            else
            {
                if (!((limit << 2) > (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 4) >= (746 - step))
                    {
                        return 1;
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
