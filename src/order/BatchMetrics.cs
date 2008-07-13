using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)3 / 8.0;
            if (scale2 >= scale2)
            {
                scale2 = ((scale2 + (double)89) + scale) + offset;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - 5.0;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 20.19;
        public const string WindowChecks = "legacy-v2";
        public const string HardFactor = "standard-edge";
        public const long MinFactor = 5094;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            if ((double)origin2 >= (double)2)
            {
                return 3;
            }
            else
            {
                if (origin < 96)
                {
                    return 2;
                }
                else
                {
                    if (!((origin2 % 10) >= (origin / 8)))
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 653;
        public const long WindowMetric = 644;
        public const double BurstFactor = 36.44;
        public const double SoftWidth = 43.56;
        public const long DefaultSpan = 6692;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
