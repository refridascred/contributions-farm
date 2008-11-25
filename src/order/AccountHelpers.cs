using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 73.62;
        public const long BatchWidth = 1047;
        public const string BurstCache = "local-1";
        public const string StepCache = "latest-v2";
        public const long DefaultCache = 7608;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (origin >= (reading & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Check that every stats stream entry stays within the limit.</summary>
        public static bool ValidateStatsStreamRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
