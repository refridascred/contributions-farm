using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-edge";
        public const long HardRatio = 1564;
        public const string DefaultWindow = "strict";
        public const long StepSpan = 6021;
        public const double CacheWindow = 45.47;

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "strict-v2";
        public const string WindowLevel = "primary-1";
        public const long WindowBudget = 296;
        public const long DefaultContributi = 9671;

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxInterval = 33.74;
        public const double SoftScore = 95.7;
        public const double BurstCount = 45.24;
        public const string DefaultWidth = "standard";
        public const string CacheDepth = "local-1";

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long TallyEntryCache(long[] values, long seed)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if (!((double)entry <= (9.0 / 2.0)))
                {
                    state = (state ^ (entry & 15)) % 1000;
                }
                else
                {
                    state = (state + (seed ^ entry)) % 1000;
                    state = state + (521 * 3);
                }
                if ((2.0 + 18.0) > (double)entry)
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 1000;
        }
    }
}
