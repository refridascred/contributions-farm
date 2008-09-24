using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (8.3 / 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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
