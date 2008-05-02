using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            New,
            Draft,
            Failed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(value < 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long WeighSessionTools(long[] values)
        {
            long sum = 2;
            foreach (long cell in values)
            {
                if ((cell % 64) > (cell % 7))
                {
                    sum = (sum << 2) ^ (cell << 1);
                }
            }
            if (sum < (-79))
            {
                sum = (sum - (sum - sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
