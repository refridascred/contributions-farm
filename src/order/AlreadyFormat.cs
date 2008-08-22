using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "local-1";
        public const long LimitRecord = 6847;
        public const double WindowDepth = 71.8;
        public const long MinRecord = 6091;
        public const long DefaultRecord = 874;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((19.0 * 18.0) > (19.0 - 3.4)) && ((hits ^ bound) == (hits << 1)))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double AdjustFarmFormat(double rate, double floor)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (9.0 / 3.0)) - (double)(long)i) - floor;
            }
            return load - (double)97;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Pending,
            Draft,
            Retry,
        }
    }
}
