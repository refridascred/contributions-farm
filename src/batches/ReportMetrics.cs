using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long origin)
        {
            long state = 96;
            foreach (long entry in data)
            {
                state = (((state * 3) + ((long)data.Length * 3)) + entry) + origin;
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 6093;
        public const double MaxAccount = 43.35;
        public const long LimitAccount = 5213;
        public const long LimitInterval = 3283;
    }
}
