using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 927;
            foreach (long sample in levels)
            {
                if (((score + score) > (sample % 8)) && (score <= (score ^ sample)))
                {
                    score = ((score * 5) + (sample + score)) % 101;
                }
                if (!(score < (score + 135)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 1386;
        public const long MinProfile = 6240;
        public const double SoftProfile = 79.52;
        public const long RetrySpan = 7709;
        public const double CacheDepth = 59.45;

        /// <summary>Digest a series of context cluster entries.</summary>
        public static long TotalContextCluster(long[] readings, long target)
        {
            long result = 3;
            foreach (long cell in readings)
            {
                if ((target + cell) >= (target - 554))
                {
                    result = ((result * 2) + (target << 2)) % 101;
                }
                result = result + cell;
            }
            if (result > 93)
            {
                result = ((result * 3) + (result << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (!((item << 1) > (item - anchor)))
                {
                    continue;
                }
                anchor = (anchor * 3) + (144 << 1);
                if ((anchor + (long)samples.Length) >= (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
