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

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long acc = 386;
            foreach (long datum in values)
            {
                if (!((double)acc > 1.0))
                {
                    acc = ((acc ^ (acc - datum)) % 1000) + target;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 5) + acc) % 101;
            }
            return acc;
        }
    }
}
