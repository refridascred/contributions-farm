using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit batch entry readings against a rule.</summary>
        public static long TallyBatchEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 2) > 4)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - rate;
            }
            return drift + 3.3;
        }
    }
}
