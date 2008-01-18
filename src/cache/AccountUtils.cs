using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-5) - floor) >= (floor ^ 129))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value - value) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
