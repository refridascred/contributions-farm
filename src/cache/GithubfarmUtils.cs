using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 7170;
        public const long BaseSpan = 3865;
        public const long StepCount = 6764;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings, long target)
        {
            long total = 543;
            foreach (long sample in readings)
            {
                if ((total * 5) > (target + target))
                {
                    total = (total ^ target) % 101;
                }
                else
                {
                    total = (total << 3) ^ (sample % 5);
                }
            }
            return total;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Paused,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-v2";
        public const long HardFactor = 4206;
        public const long BaseWidth = 7250;
    }
}
