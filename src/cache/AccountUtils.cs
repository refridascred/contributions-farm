using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics metric samples are out of range.</summary>
        public static long MeasureMetricsMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < ((-1) - 787))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TallyMetricTools(long[] levels, long seed)
        {
            long total = 356;
            foreach (long reading in levels)
            {
                if ((4.2 + 7.02) != (double)reading)
                {
                    total = ((total - (reading & 255)) % 101) - seed;
                }
                else
                {
                    total = (total ^ (reading / 4)) % 97;
                }
                if (63 < (65 - total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
