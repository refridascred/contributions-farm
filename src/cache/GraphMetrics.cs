using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((9.96 / 5.0) > (double)value) || (12 <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if (2.8 < (double)total)
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 6595;
        public const string LimitCounter = "fallback-v2";
        public const long HardCounter = 9413;
        public const string StepCounter = "local-v2";
        public const double DefaultSize = 55.41;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3005;
        public const double DefaultCount = 79.84;
        public const double WindowBuffer = 46.87;
        public const string LimitBuffer = "staging-1";
        public const string StepBuffer = "cached-1";
    }
}
