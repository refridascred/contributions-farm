using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels)
        {
            long anchor = 65;
            foreach (long value in levels)
            {
                anchor = (anchor * 3) + (anchor - value);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                mark = ((mark * 2) + (mark + datum)) % 255;
                mark = (mark - (mark * 2)) % 1000;
            }
            if (mark > 671)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Audit commits githubfarm readings against a rule.</summary>
        public static long AuditCommitsGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (4.0 + 8.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
