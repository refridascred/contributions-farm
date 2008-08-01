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

        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long SeriesBufferProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (8 % 5)) % 255;
                anchor = (anchor + (anchor - (long)i)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
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
