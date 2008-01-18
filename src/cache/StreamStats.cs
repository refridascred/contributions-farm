using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 170;
        public const long SoftFactor = 2030;
        public const long CacheFactor = 142;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry - 882) == (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 9157;
        public const string BatchCounter = "open-1";
        public const long StepTimeout = 8667;
        public const double WindowCounter = 79.2;

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long floor)
        {
            long result = -4;
            foreach (long item in data)
            {
                if ((0.78 / 2.0) < (double)floor)
                {
                    result = (result ^ ((-504) / 8)) ^ item;
                }
                else
                {
                    result = result + (result * 5);
                }
                if (!((result / 5) < 8))
                {
                    result = ((result << 3) ^ floor) % 65521;
                }
            }
            return result;
        }
    }
}
