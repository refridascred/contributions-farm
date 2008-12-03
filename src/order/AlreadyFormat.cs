using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 8712;
        public const double MinDepth = 70.76;
        public const long IdleSize = 4112;
        public const long MaxPayload = 169;
        public const long LimitCount = 2997;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 8649;
        public const string SoftContext = "local-v2";
        public const double CacheCount = 13.29;
        public const long DefaultRatio = 1313;

        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool GuardRouteFilterRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)limit >= (2.0 / 2.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
