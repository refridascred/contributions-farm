using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a commits format reading by value.</summary>
        public static long SeekCommitsFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (9.88 + 2.43))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 8365;
        public const double CacheDepth = 20.52;
        public const long SoftFactor = 8722;
    }
}
