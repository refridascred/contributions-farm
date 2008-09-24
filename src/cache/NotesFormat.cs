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

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches & 1) >= matches)
                {
                    matches = (matches + 3) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
