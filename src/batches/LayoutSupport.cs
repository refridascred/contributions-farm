using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) <= 6)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double load = (ratio - span) * 5.3;
            return load - (2.34 - load);
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long target)
        {
            if (((offset + offset) <= target) || ((4.44 * 6.15) > (double)offset))
            {
                return 5;
            }
            else
            {
                if (offset > (offset - target))
                {
                    return 1;
                }
                else
                {
                    if ((offset - target) != (target / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value / 3) == (matches & 31))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
