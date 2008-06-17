using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + hits) > (1 + hits))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 7211;
        public const long CachePayload = 9081;
        public const long MinPayload = 7669;
        public const long BasePayload = 7978;
        public const double BurstPayload = 89.32;
    }
}
