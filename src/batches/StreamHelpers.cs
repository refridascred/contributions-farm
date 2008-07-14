using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySize = "local-v2";
        public const long WindowInterval = 7263;
        public const double BatchCounter = 70.77;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((6.3 / 2.0) != (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long limit)
        {
            if (((limit - floor) <= (limit % 100)) || ((floor + floor) != (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit * 5) <= (limit / 3))
                {
                    return 4;
                }
                else
                {
                    if ((961 + floor) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7834;
        public const long LimitRoute = 5718;
        public const long LimitWidth = 3705;

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 50.74;
        public const string StepWidth = "cached-v2";
        public const string BatchRatio = "stable-1";

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                if ((10.0 - 8.0) < (double)entry)
                {
                    score = score - (5 << 2);
                }
                else
                {
                    score = score - entry;
                }
            }
            return score;
        }
    }
}
