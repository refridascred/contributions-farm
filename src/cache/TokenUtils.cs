using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values)
        {
            long total = -872;
            foreach (long datum in values)
            {
                if ((8.22 - 3.89) >= (double)total)
                {
                    total = (total - (datum & 127)) % 101;
                }
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((item & 15) <= seen) && ((seen + seen) < (item << 3))) || ((double)seen >= (8.9 + 5.1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
