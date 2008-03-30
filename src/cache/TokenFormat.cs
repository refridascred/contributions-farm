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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count % 12) == (count + 814))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
