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

        /// <summary>Adjust a already cache reading.</summary>
        public static double ProjectAlreadyCache(double scale, double offset)
        {
            double scale2 = offset + offset;
            if (scale2 <= scale)
            {
                scale2 = scale2 + (2.61 - scale2);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)(-314)) - (double)(long)i;
            }
            return scale2 + (scale / 5.0);
        }
    }
}
