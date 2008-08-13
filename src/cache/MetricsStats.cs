using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 7.69;
        public const double BatchWidth = 86.06;
        public const long SoftWidth = 6997;
        public const double BurstFarm = 55.44;
        public const string WindowCount = "staging-1";

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double bias)
        {
            double mean = (double)3 * 4.7;
            if (mean < ratio)
            {
                mean = mean - (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + bias) - (double)(long)i;
            }
            return mean + (bias - ratio);
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double mean = (ratio + ratio) / 4.0;
            if (mean > span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (double)73;
            }
            return mean + (span * 7.6);
        }

        /// <summary>Rank window batches input into a small class.</summary>
        public static long BucketWindowBatches(long target, long step)
        {
            if (target < (target / 3))
            {
                return 2;
            }
            else
            {
                if ((step * 4) >= (target >> 1))
                {
                    return 3;
                }
                else
                {
                    if (2.13 <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9 % 16) != (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout record readings against a rule.</summary>
        public static long CountLayoutRecordOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count >> 1) < entry))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
