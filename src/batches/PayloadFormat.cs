using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheWidth = 7117;
        public const string DefaultRatio = "staging";
        public const long HardFactor = 5087;
        public const string SoftSize = "alpha-v2";
        public const string BaseEntry = "latest-v2";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)sample)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((double)mix <= 7.0)
                {
                    mix = ((mix ^ (entry + entry)) % 65521) + bound;
                }
            }
            return mix;
        }
    }
}
