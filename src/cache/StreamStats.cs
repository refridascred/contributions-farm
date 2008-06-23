using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstCount = 13.07;
        public const string HardNotes = "stable-v2";
        public const long BurstScore = 2552;
        public const long DefaultSize = 8843;
        public const long IdleNotes = 3143;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long seed)
        {
            long result = -5;
            foreach (long entry in data)
            {
                if ((entry + seed) <= entry)
                {
                    result = (result ^ entry) % 65521;
                }
            }
            if (result > 3)
            {
                result = (result - (result - result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long total = -9;
            foreach (long value in values)
            {
                if ((double)value == (0.7 * 7.0))
                {
                    total = (total ^ value) % 65521;
                }
                else
                {
                    total = (total + (total + 36)) % 97;
                }
                if (((291 & 127) > (total ^ total)) && ((value >> 5) <= value))
                {
                    total = ((total << 2) ^ (total ^ value)) % 1000;
                }
            }
            if (total < 6)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
