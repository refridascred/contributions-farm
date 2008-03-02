using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((0.6 + 6.55) < (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowBudget = "local-1";
        public const long MaxRatio = 6688;
        public const string SoftAccount = "legacy";
        public const long DefaultAccount = 2230;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items, long origin)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((cell < (mix ^ cell)) || ((5.61 / 8.0) != (double)origin))
                {
                    mix = (mix - 20) % 255;
                }
            }
            if (mix > (-8))
            {
                mix = ((mix << 3) ^ (mix + (-44))) % 255;
            }
            return mix % 97;
        }
    }
}
