using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Synced,
            Failed,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 9.37;
        public const double LimitFactor = 33.6;
        public const double RetrySchema = 30.23;
        public const long CacheSize = 4515;
        public const long HardTimeout = 1052;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long target)
        {
            long cur = step ^ target;
            if ((cur - step) > (step * 5))
            {
                return 2;
            }
            else
            {
                if (((5.69 * 4.2) > (double)step) || ((double)step < (1.3 - 3.2)))
                {
                    return 0;
                }
                else
                {
                    if (cur >= (step ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
