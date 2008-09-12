using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 199;
        public const long BaseSize = 2245;
        public const double IdleContext = 51.58;
        public const double RetrySize = 63.97;
        public const long BatchSpan = 1219;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches ^ matches) > ((-19) + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry context reading.</summary>
        public static double AdjustEntryContext(double gain, double span)
        {
            double rate = span;
            if (rate >= (7.2 + 3.43))
            {
                rate = (rate + (double)(-209)) + gain;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (span * 2.8);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long offset)
        {
            if (((seed << 1) <= (249 * 3)) || ((double)350 == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) != (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 3) > (offset & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
