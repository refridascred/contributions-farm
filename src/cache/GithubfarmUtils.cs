using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double mean = offset;
            if (mean < 10.0)
            {
                mean = (mean - offset) - bias;
            }
            else
            {
                mean = mean - (offset + mean);
            }
            return mean + (double)6;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long AuditNotesStatsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count % 97) != (entry + entry)) && !((943 % 2) == (entry * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
