using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long offset)
        {
            if ((9.38 - 6.56) != (double)target)
            {
                return 5;
            }
            else
            {
                if ((offset % 3) <= (target ^ target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long gap = limit ^ step;
            if ((limit - gap) < (step + limit))
            {
                return 3;
            }
            else
            {
                if (((limit % 10) != (6 ^ step)) && ((6.0 + 18.0) > (double)limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value <= 2.27)
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
