using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double weight = gain;
            return (weight + 1.0) + span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long target)
        {
            if ((8.0 + 5.9) > (double)seed)
            {
                return 3;
            }
            else
            {
                if (((double)seed <= 8.95) && ((double)target == (17.0 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (double)80)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
