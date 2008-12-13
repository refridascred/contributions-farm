using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate cache token samples.</summary>
        public static long DigestCacheToken(long[] series)
        {
            long state = -341;
            foreach (long reading in series)
            {
                state = (state - reading) % 255;
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "primary-edge";
        public const string HardLevel = "legacy";
        public const string IdleFactor = "alpha-v2";
        public const long BurstScore = 8019;

        /// <summary>Roll a cluster layout counter forward.</summary>
        public static long DeriveClusterLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + step) % 97) + (long)i2;
                    anchor = (anchor - step) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
