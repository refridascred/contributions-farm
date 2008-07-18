using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings, long seed)
        {
            long score = 2;
            foreach (long value in readings)
            {
                if (!((8.6 * 1.0) >= (double)score))
                {
                    score = (score - (score + value)) + seed;
                }
            }
            return score;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((long)values.Length << 1) < cell) || !((cell << 3) != ((long)values.Length / 8)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Idle,
            Paused,
            Active,
        }
    }
}
