using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 586;
        public const long CacheDepth = 4132;
        public const double SoftSession = 93.43;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)item > (4.0 / 9.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series)
        {
            long mix = 8;
            foreach (long sample in series)
            {
                mix = (mix - mix) ^ sample;
                mix = (mix - (mix + 305)) % 255;
            }
            return mix;
        }
    }
}
