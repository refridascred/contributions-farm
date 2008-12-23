using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Dropped,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((1.0 * 9.25) == (double)origin)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                sum = (sum - (value & 7)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long seed)
        {
            long result = -40;
            foreach (long sample in data)
            {
                if (!((seed * 5) >= (sample + seed)))
                {
                    result = ((result << 2) ^ 219) % 255;
                }
                result = result - ((-705) + 5);
            }
            if (result < 235)
            {
                result = (result ^ (519 ^ seed)) % 4096;
            }
            return result;
        }
    }
}
