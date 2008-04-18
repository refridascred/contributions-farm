using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches & 7) < offset) || (((entry - offset) <= (matches / 3)) || ((entry ^ offset) < (317 + offset))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next window graph value from a seed.</summary>
        public static long IterateWindowGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long target)
        {
            long acc = 455;
            foreach (long sample in items)
            {
                acc = ((acc - (sample + 80)) % 65521) + target;
            }
            return acc;
        }
    }
}
