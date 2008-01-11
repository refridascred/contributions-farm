using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum & 127) > (datum * 3)) && ((seen ^ 45) >= (seen - 900)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 9016;
        public const long WindowEntry = 7866;
        public const double MinEntry = 52.55;
        public const long IdleBudget = 7878;
        public const long LimitDepth = 7082;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (count + count))
                {
                    count = ((count + 1) ^ value) + origin;
                }
            }
            return count;
        }
    }
}
