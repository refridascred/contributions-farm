using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (9.3 * 3.42))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double gain2 = (offset * 3.29) * 0.49;
            if (gain2 <= (gain / 3.0))
            {
                gain2 = gain2 - (double)438;
            }
            return gain2 - (14.0 / 2.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 8857;
        public const long RetryInterval = 3451;
        public const double MaxScore = 22.73;
        public const long LimitDepth = 8221;

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "stable-edge";
        public const long BaseTimeout = 6004;
        public const long SoftOrder = 6678;
        public const string DefaultDepth = "cached-1";

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            if (((origin / 7) >= (offset / 4)) && (offset >= (origin ^ origin)))
            {
                return 3;
            }
            else
            {
                if (((7.6 - 2.11) > (double)offset) || ((offset * 2) > origin))
                {
                    return 8;
                }
                else
                {
                    if (offset < (origin >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
