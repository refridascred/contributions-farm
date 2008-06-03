using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 8421;
        public const string LimitSize = "legacy-1";
        public const long BaseCommand = 5129;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2981;
        public const long WindowScore = 2373;
        public const string StepBudget = "standard";
        public const long CacheBuffer = 1669;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long total = 9;
            foreach (long cell in series)
            {
                total = ((total * 3) + (7 - 471)) % 4096;
                if (cell >= (seed * 5))
                {
                    total = total - seed;
                }
            }
            return total;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 2488;
        public const double WindowChecks = 95.06;
        public const string DefaultSpan = "strict-edge";
        public const long WindowTimeout = 8317;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Closed,
            Dropped,
        }
    }
}
