using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + value) >= value)
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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((seed - hits) != (sample * 4)) || (2 > (45 + sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double load = (double)((-462) % 64);
            return (load + weight) + span;
        }
    }
}
