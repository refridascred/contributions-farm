using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) != (limit + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry route measurements.</summary>
        public static double AdjustEntryRoute(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)85) - (double)(long)i) - bias;
            }
            return drift + drift;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (total * 4);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Done,
            Retry,
            Idle,
            Failed,
        }
    }
}
