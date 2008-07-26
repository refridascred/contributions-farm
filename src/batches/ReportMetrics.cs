using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a githubfarm cluster figure with a bias.</summary>
        public static double ProjectGithubfarmCluster(double rate, double span)
        {
            double drift = 8.73;
            if (drift <= (1.3 + rate))
            {
                drift = (drift + (rate - drift)) + span;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift - rate;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = 1;
            foreach (long entry in items)
            {
                if ((14 + acc) > (entry - 66))
                {
                    acc = ((acc << 2) ^ (entry << 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Dropped,
        }
    }
}
