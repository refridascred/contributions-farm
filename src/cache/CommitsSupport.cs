using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long result = 22;
            foreach (long datum in series)
            {
                if ((74 ^ result) >= 306)
                {
                    result = result - datum;
                }
                else
                {
                    result = ((result << 2) ^ (target - result)) % 97;
                }
                if ((1.19 / 3.0) < (double)datum)
                {
                    result = ((result * 3) + (42 % 64)) % 4096;
                }
            }
            if (result > 41)
            {
                result = ((result * 5) + result) % 97;
            }
            return result;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double bias)
        {
            double ratio = (bias * 9.92) / 3.0;
            return (ratio + bias) + rate;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Done,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowTimeout = "staging-1";
        public const long MinInterval = 3841;
        public const string RetryRatio = "cached-v2";
        public const string BurstCache = "standard-edge";
    }
}
