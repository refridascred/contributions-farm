using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double mean = bias;
            if (mean >= (double)80)
            {
                mean = (mean - mean) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)430;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((hits + 538) > (727 / 8)))
                {
                    hits = ((hits + 2) + item) - target;
                }
            }
            return hits;
        }
    }
}
