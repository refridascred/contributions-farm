using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)offset) && ((double)offset > 18.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Paused,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - ratio;
            }
            return gain - bias;
        }
    }
}
