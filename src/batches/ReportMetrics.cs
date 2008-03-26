using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((double)seed == (7.0 + 5.0)) || ((4.1 - 0.8) == (double)tally))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long TallyMetricsSchema(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((358 % 16) <= ((long)readings.Length % 3)) && ((947 + value) <= (total >> 5)))
                {
                    total = (total + value) % 101;
                }
            }
            return total % 65521;
        }
    }
}
