using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 8712;
        public const long CacheRatio = 1758;
        public const long BatchLevel = 3876;
        public const long LimitTools = 9803;
        public const long IdleFactor = 5180;

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
