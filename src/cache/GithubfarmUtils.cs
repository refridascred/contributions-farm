using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double bias)
        {
            double bias2 = 6.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + rate) + (double)(long)i) - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics editor readings.</summary>
        public static long FoldMetricsEditor(long[] items, long offset)
        {
            long anchor = 48;
            foreach (long cell in items)
            {
                if ((double)(-44) == (double)anchor)
                {
                    anchor = ((anchor + (anchor - anchor)) - cell) + offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
