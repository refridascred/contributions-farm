using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)seed < (10.0 - 8.1)))
                {
                    anchor = ((anchor << 2) ^ (seed ^ seed)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 7636;
        public const long DefaultEditor = 1966;
        public const long BurstEditor = 3656;
        public const long HardSpan = 5835;
        public const double DefaultTimeout = 88.31;

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((bound * 2) == ((-72) + bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + bound) >= (step + origin)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
