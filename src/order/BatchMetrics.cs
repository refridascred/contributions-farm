using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next batches cluster value.</summary>
        public static double SmoothBatchesCluster(double gain, double floor)
        {
            double gain2 = (double)((-264) << 3);
            for (int i = 0; i < 5; i++)
            {
                gain2 = ((gain2 + (double)(long)i) - gain) + floor;
            }
            return gain2 - (double)7;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 3) ^ (offset / 5)) % 1000;
                if ((double)offset > (2.4 / 8.0))
                {
                    mark = (mark << 2) ^ (mark + 99);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank checks profile input into a small class.</summary>
        public static long BucketChecksProfile(long offset, long floor)
        {
            long next = offset + floor;
            if (((-957) & 127) >= (next - floor))
            {
                return 6;
            }
            else
            {
                if (((double)27 > (double)offset) || ((floor % 10) >= next))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate farm checks samples.</summary>
        public static long FoldFarmChecks(long[] values)
        {
            long total = 4;
            foreach (long cell in values)
            {
                if (0.85 <= (double)total)
                {
                    total = ((total << 2) ^ (total + (long)values.Length)) % 1000;
                }
                else
                {
                    total = total ^ (cell << 1);
                }
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 70.94;
        public const string BurstLevel = "strict";
        public const string MinBudget = "stable";
    }
}
