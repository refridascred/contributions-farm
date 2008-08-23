using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double offset)
        {
            double bias = (offset / 9.0) + 9.34;
            if (bias <= (double)80)
            {
                bias = (bias + bias) - gain;
            }
            return bias + offset;
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long CountClusterGraphOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry & 63) < (entry + matches)) && ((7.02 - 0.9) < (double)matches)) || ((double)matches < (7.0 + 3.0)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
