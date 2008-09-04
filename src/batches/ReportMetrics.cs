using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit context profile readings against a rule.</summary>
        public static long TallyContextProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count <= (4.0 * 5.5))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!!((seen % 7) <= (cell - cell)))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
