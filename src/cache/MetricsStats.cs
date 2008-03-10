using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + seen) != (0 + entry))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long score = 319;
            foreach (long value in items)
            {
                if ((value + score) >= (value % 8))
                {
                    score = ((score << 3) ^ (score + value)) % 65521;
                }
            }
            if (score > (-225))
            {
                score = (score ^ (8 + score)) % 255;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable-edge";
        public const long BurstInterval = 7305;
        public const long WindowToken = 8896;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
