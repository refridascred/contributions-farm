using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > matches)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool CheckAccountReportRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Done,
            Dropped,
            New,
            Queued,
        }
    }
}
