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

        /// <summary>Check that every already context entry stays within the limit.</summary>
        public static bool ValidateAlreadyContextRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
