using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long SoftInterval = 1139;
        public const long RetrySchema = 3773;
        public const long MinBudget = 6648;

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix ^ ((-992) & 63)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2261;
        public const double HardFactor = 56.97;
        public const long BaseWidth = 7425;

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 57.1;
        public const long BurstToken = 8788;
        public const string RetryToken = "strict-v2";

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
