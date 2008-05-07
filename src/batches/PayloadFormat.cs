using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            New,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long seed)
        {
            long acc = 492;
            foreach (long value in series)
            {
                if (((-393) >> 3) < acc)
                {
                    acc = ((acc * 2) + (26 + 86)) + value;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                if (seed >= (seed + acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleRatio = 5786;
        public const string HardCount = "standard";
        public const long CacheRatio = 2975;
        public const long StepLevel = 7905;
    }
}
