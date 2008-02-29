using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 4715;
        public const double IdleCommits = 82.96;
        public const long SoftCommits = 3647;
        public const long HardCommits = 1123;
        public const long MaxCommits = 4806;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8289;
        public const long StepFactor = 2716;
        public const long BatchSpan = 1293;
        public const long StepNotes = 9316;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long limit)
        {
            if (((5 >> 2) > (4 - limit)) && ((limit - 266) < (target << 2)))
            {
                return 5;
            }
            else
            {
                if (target <= (target % 60))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches >> 4) > (entry + 295))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
