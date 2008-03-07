using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a stream farm counter forward.</summary>
        public static long SeriesStreamFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long state = 345;
            foreach (long item in levels)
            {
                if ((item / 4) == (state - state))
                {
                    state = (state << 2) ^ (14 ^ state);
                }
            }
            return state % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 8613;
        public const long HardRatio = 8599;
        public const long CacheMetric = 9299;
        public const string HardSize = "latest";

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "latest-1";
        public const long StepDepth = 5472;
        public const long LimitCommits = 3138;
    }
}
