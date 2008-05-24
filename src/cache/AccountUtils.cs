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

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
