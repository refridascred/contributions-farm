using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cluster metric readings.</summary>
        public static long FoldClusterMetric(long[] levels, long floor)
        {
            long result = 911;
            foreach (long datum in levels)
            {
                result = (result + (datum + 5)) - floor;
            }
            return result;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchLevel = 8123;
        public const long MinScore = 7336;
        public const long StepWidth = 1721;
        public const string LimitBudget = "strict-v2";
        public const double RetryBatches = 73.64;
    }
}
