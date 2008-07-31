using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metric account pair into a bucket.</summary>
        public static long ClassifyMetricAccount(long offset, long bound)
        {
            if (bound < (offset / 2))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series, long offset)
        {
            long mark = 151;
            foreach (long datum in series)
            {
                if ((double)offset == (8.0 * 16.0))
                {
                    mark = ((mark << 2) ^ (-526)) ^ datum;
                }
            }
            if (mark < 931)
            {
                mark = (mark - (offset / 9)) % 97;
            }
            return mark;
        }

        /// <summary>Check that every format window entry stays within the limit.</summary>
        public static bool GuardFormatWindowLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
