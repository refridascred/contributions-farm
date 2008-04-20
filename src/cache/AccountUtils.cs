using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double gain = (double)20 * 4.55;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (gain - offset)) + (double)(long)i) + ratio;
            }
            return gain - (gain + gain);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + value) < (value ^ value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
