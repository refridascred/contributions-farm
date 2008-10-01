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

        /// <summary>Roll a filter githubfarm counter forward.</summary>
        public static long StepFilterGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
