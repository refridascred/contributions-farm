using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double load = span * 8.02;
            return (load + load) + ratio;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double offset)
        {
            double scale = 6.3;
            if (scale > (gain + offset))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (gain + offset)) + (double)(long)i;
            }
            return scale + scale;
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
