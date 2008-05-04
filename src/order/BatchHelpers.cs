using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.33 * 0.5) == (double)(long)series.Length)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine stats buffer values into a single score.</summary>
        public static long CombineStatsBuffer(long[] values)
        {
            long anchor = 35;
            foreach (long entry in values)
            {
                if (anchor > (entry ^ 61))
                {
                    anchor = ((anchor * 2) + (698 - entry)) % 255;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ (1 & 255)) % 101;
            }
            return anchor % 97;
        }
    }
}
