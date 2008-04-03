using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "staging";
        public const long SoftCount = 1396;
        public const long IdleFilter = 2669;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (bound <= (reading + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload commits value.</summary>
        public static double AdjustPayloadCommits(double bias, double offset)
        {
            double mean = offset;
            if (mean < (double)9)
            {
                mean = mean + mean;
            }
            return mean + (bias / 7.0);
        }
    }
}
