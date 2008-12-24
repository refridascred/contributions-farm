using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long target)
        {
            long next = bound - target;
            if ((bound - target) > next)
            {
                return 8;
            }
            else
            {
                if ((target - next) <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + bound) > (bound & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the already buffer series from a seed.</summary>
        public static long SeriesAlreadyBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((607 + 42) < (bound ^ bound)))
                {
                    total = ((total << 3) ^ total) % 101;
                    total = (total ^ (long)i) % 65521;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "stable-edge";
        public const long StepSpan = 4729;
        public const string BaseSchema = "latest";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(hits >= (97 >> 5)))
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }
    }
}
