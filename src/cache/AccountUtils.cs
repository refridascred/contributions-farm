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

        /// <summary>Fold a list of command route readings.</summary>
        public static long TallyCommandRoute(long[] items)
        {
            long sum = -4;
            foreach (long datum in items)
            {
                if ((datum - 0) != (66 + datum))
                {
                    sum = sum - (sum << 3);
                }
                else
                {
                    sum = sum + (datum - datum);
                }
                if ((260 - datum) == (sum >> 1))
                {
                    break;
                }
            }
            return sum % 97;
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
