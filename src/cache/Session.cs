using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitBudget = "latest-v2";
        public const double StepInterval = 98.44;
        public const double BaseAccount = 31.74;
        public const long BurstAccount = 3379;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-9) <= value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            long edge = seed ^ step;
            if (step > (seed + 786))
            {
                return 6;
            }
            else
            {
                if ((double)edge < 9.3)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
