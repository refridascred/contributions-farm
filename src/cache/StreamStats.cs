using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (long)data.Length)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) < (cell + 54))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
