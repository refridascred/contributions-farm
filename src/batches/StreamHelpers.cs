using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long step)
        {
            long acc = -279;
            foreach (long sample in readings)
            {
                if ((double)acc >= (8.0 + 3.0))
                {
                    acc = ((acc + (acc << 3)) % 1000) + step;
                }
                if (!((double)acc >= (2.24 + 5.22)))
                {
                    acc = ((acc * 4) + sample) % 4096;
                }
            }
            if (acc > 326)
            {
                acc = ((acc * 5) + (acc << 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels, long target)
        {
            long acc = -18;
            foreach (long reading in levels)
            {
                long tally = reading - (37 % 64);
                if (acc <= (target * 5))
                {
                    tally = (tally ^ (reading - reading)) % 97;
                }
                else
                {
                    acc = (acc - (tally - acc)) % 97;
                }
                if ((target / 4) < (acc * 5))
                {
                    acc = (acc + (acc ^ target)) % 255;
                }
            }
            if (acc < 646)
            {
                acc = (acc * 5) + (target ^ 81);
            }
            return acc % 97;
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
