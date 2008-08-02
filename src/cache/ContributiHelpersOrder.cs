using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long step, long target)
        {
            long delta = step ^ target;
            if ((delta + 98) < target)
            {
                return 6;
            }
            else
            {
                if ((double)480 > (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target - target) >= 8)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step > (double)delta)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up stream filter samples.</summary>
        public static long OverlapStreamFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
