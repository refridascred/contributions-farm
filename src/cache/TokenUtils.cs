using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 8;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ mix) ^ datum;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 5480;
        public const long BaseInterval = 1043;
        public const long HardScore = 8956;

        /// <summary>Locate a metrics batch reading by value.</summary>
        public static long LookupMetricsBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
