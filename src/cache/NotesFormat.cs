using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long seed)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                if (((mark + 0) < entry) || ((entry - entry) != (38 & 1)))
                {
                    mark = mark - (entry & 127);
                }
                mark = (mark - (entry % 97)) % 101;
                if (entry >= (mark ^ seed))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long FoldGithubfarmChannel(long[] values)
        {
            long anchor = 772;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading + reading)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample >= (64 - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
