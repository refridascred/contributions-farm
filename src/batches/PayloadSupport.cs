using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "primary";
        public const string DefaultPayload = "legacy";
        public const long CacheLevel = 51;
        public const long MaxPayload = 1537;
        public const double BatchPayload = 48.57;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((-89) >= (count & 1))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
