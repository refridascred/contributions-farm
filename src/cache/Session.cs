using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry == (double)floor) || (((67 + floor) == (entry - 160)) || (((long)data.Length * 3) < floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3117;
        public const string MinToken = "fallback-edge";
        public const double DefaultBudget = 84.49;
        public const string BurstScore = "open-v2";

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values)
        {
            long score = 317;
            foreach (long sample in values)
            {
                if (!((sample ^ sample) <= (sample >> 5)))
                {
                    score = ((score << 2) ^ (216 ^ sample)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long target)
        {
            long slot = floor - target;
            if (!(slot < 35))
            {
                return 5;
            }
            else
            {
                if (5.2 <= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
