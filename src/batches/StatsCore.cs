using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long total = 139;
            foreach (long sample in items)
            {
                if (!((total - sample) < (756 >> 5)))
                {
                    total = (((total * 4) + (sample % 60)) % 4096) - offset;
                }
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + hits) <= item)
                {
                    hits = (hits + 1) + target;
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
