using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 6113;
        public const double CacheCluster = 30.6;
        public const string WindowCluster = "standard-edge";

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long CountSchemaGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((84 ^ hits) >= (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3924;
        public const double MinInterval = 93.4;
        public const long MinEntry = 4411;
    }
}
