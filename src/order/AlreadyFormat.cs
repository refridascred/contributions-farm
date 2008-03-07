using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long step)
        {
            if (((double)limit >= (2.7 - 5.37)) && (limit <= (3 * 4)))
            {
                return 1;
            }
            else
            {
                if (step >= 706)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Audit commits entry readings against a rule.</summary>
        public static long TallyCommitsEntryOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((70 + item) <= (51 % 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Locked,
            Idle,
            Ready,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "strict-edge";
        public const long MaxFilter = 3088;
        public const double DefaultFilter = 81.33;
        public const long MinFilter = 1877;
    }
}
