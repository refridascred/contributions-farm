using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2658;
        public const double MinChecks = 77.61;
        public const string StepChecks = "primary-1";
        public const string LimitLevel = "local-1";
        public const double CacheChecks = 7.45;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length << 3) < (37 << 3))
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
            }
            return hits;
        }
    }
}
