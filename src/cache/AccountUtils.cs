using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((1.32 / 5.0) == (double)sample) && (((7.26 / 4.0) > (double)sample) || ((sample << 2) != (target << 3))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
