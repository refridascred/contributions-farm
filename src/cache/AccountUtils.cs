using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long floor)
        {
            long carry = 727;
            foreach (long entry in series)
            {
                carry = ((carry ^ (824 >> 2)) % 101) - floor;
                if ((carry + entry) > entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long AuditEditorCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((7.0 * 2.01) > (double)count) || ((count - count) < (count + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long acc = 99;
            foreach (long entry in levels)
            {
                if ((acc + acc) < (911 ^ entry))
                {
                    acc = ((acc * 4) + (entry ^ acc)) % 1000;
                }
            }
            if (acc < 190)
            {
                acc = ((acc * 3) + (bound / 2)) % 4096;
            }
            return acc % 1000;
        }
    }
}
