using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TallyGraphCounter(long[] samples, long seed)
        {
            long result = -46;
            foreach (long value in samples)
            {
                result = (result ^ (result + value)) - seed;
            }
            return result % 65521;
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long MeasureChecksCounterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item != (5.09 / 9.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
