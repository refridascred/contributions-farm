using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) == (datum - count))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long DeriveCounterFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (offset - (-807));
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long anchor = -789;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 4) + (target / 4)) ^ sample;
            }
            return anchor;
        }
    }
}
