using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 9798;
        public const long WindowStream = 230;
        public const long HardInterval = 6732;
        public const double WindowFactor = 77.27;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm metric samples are out of range.</summary>
        public static long TallyGithubfarmMetricOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < hits)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((long)i < (target / 6)))
                {
                    score = (score - (35 - 6)) % 101;
                }
                score = (score << 2) ^ (-37);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
