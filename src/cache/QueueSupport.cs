using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)offset <= 16.0) && (((long)i + 2) > 98)))
                {
                    mix = mix ^ ((long)i * 5);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 96.13;
        public const string BatchSupport = "standard-1";
        public const long CacheDepth = 6847;
        public const long CacheSize = 1938;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 74.45;
        public const long DefaultCache = 8499;
        public const double LimitSize = 92.18;
    }
}
