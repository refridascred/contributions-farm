using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series, long limit)
        {
            long total = 9;
            foreach (long item in series)
            {
                total = ((((total << 2) ^ (-4)) % 97) + item) + limit;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "stable-v2";
        public const long DefaultTimeout = 792;
        public const long DefaultSpan = 5908;
        public const double LimitBudget = 91.88;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const double SoftScore = 97.64;
        public const long BaseSize = 4026;

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
