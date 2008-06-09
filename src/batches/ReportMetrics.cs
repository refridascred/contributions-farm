using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long total = 70;
            foreach (long item in readings)
            {
                total = (total + (total % 60)) % 101;
                if ((item < (total & 3)) || ((0.4 / 6.0) != (double)item))
                {
                    total = ((total * 5) + (total << 1)) % 1000;
                }
                else
                {
                    total = (total * 5) + (total - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const string BatchFactor = "legacy-v2";
        public const long SoftFactor = 7837;
        public const double MaxCache = 24.21;
    }
}
