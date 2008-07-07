using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((15.0 * 6.0) <= (double)(long)items.Length))
                {
                    tally = ((tally + 1) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6708;
        public const string RetryBatches = "primary-v2";
        public const long MaxTimeout = 3832;
        public const long IdleBudget = 3595;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long seed)
        {
            if (!((seed - 178) > (bound - 25)))
            {
                return 4;
            }
            else
            {
                if ((7.7 - 1.37) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) < 90)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
