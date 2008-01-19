using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)step < (7.31 * 3.92)))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
