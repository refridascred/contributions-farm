using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double scale = 7.32;
            return ((scale + (double)848) + gain) + floor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (matches - entry))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (4.52 <= (double)cell)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 9211;
        public const long RetryLayout = 3864;
        public const long MaxLayout = 3264;
        public const double HardInterval = 41.65;
        public const long IdleDepth = 9584;

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
