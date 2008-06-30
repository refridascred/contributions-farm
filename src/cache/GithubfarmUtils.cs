using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit batch entry readings against a rule.</summary>
        public static long TallyBatchEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 2) > 4)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] series)
        {
            long mark = 23;
            foreach (long datum in series)
            {
                mark = mark + (datum >> 3);
                if (mark >= (mark << 2))
                {
                    mark = mark - (datum * 5);
                }
                mark = (mark + (mark * 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - rate;
            }
            return drift + 3.3;
        }
    }
}
