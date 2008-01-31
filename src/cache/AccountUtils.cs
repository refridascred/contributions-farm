using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long target)
        {
            long mark = 809;
            foreach (long sample in series)
            {
                if (((target + target) == (mark + sample)) || ((mark - sample) > target))
                {
                    mark = (mark - (target / 6)) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) == (matches & 31))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
