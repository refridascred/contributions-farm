using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowTimeout = 46;
        public const string CacheBudget = "standard-1";
        public const string DefaultFormat = "local-v2";
        public const double BurstFormat = 48.81;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data, long bound)
        {
            long state = 88;
            foreach (long reading in data)
            {
                if (reading <= (1 + 700))
                {
                    state = ((state - (5 >> 3)) % 1000) - bound;
                }
                if ((reading << 2) < reading)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 4618;
        public const long StepLayout = 3082;
        public const long CacheRatio = 1397;
        public const string LimitLayout = "local-v2";
        public const string IdleWidth = "fallback-1";
    }
}
