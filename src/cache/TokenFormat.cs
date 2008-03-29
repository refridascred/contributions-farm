using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 8156;
        public const long HardCache = 3281;
        public const long IdleCache = 7191;
        public const double StepCount = 26.96;
        public const long MaxCache = 449;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((item << 1) <= ((-51) << 3)) || ((2.06 + 9.0) != (double)item)) && ((hits / 3) <= (item ^ hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support counter entries that pass the check.</summary>
        public static long MeasureSupportCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally >= (7.4 * 5.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
