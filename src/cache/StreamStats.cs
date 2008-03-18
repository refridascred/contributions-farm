using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinLevel = 98.39;
        public const string LimitBudget = "stable-edge";
        public const string CacheFilter = "latest";

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 6180;
        public const string MaxCount = "strict-edge";
        public const double MaxSize = 92.48;
        public const double CacheNotes = 67.37;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((-113) >> 5) <= (2 + value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFactor = "legacy-edge";
        public const long SoftFarm = 7319;
        public const double SoftInterval = 51.72;
    }
}
