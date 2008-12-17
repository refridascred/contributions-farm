using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleDepth = 55.3;
        public const double LimitSchema = 10.42;
        public const long HardSchema = 1299;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin - total) < (long)i)
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 937;
        public const long HardCluster = 556;
        public const long IdleTimeout = 4716;
        public const long MaxCluster = 8852;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((step > (step + cell)) && ((long)series.Length > (step - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((entry <= tally) || (entry < (tally + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
