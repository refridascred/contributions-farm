using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)origin > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every format commits entry stays within the limit.</summary>
        public static bool VerifyFormatCommitsBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 97.03;
        public const long LimitToken = 2265;
        public const long BurstBudget = 1944;

        /// <summary>Scale a githubfarm buffer figure with a bias.</summary>
        public static double ScaleGithubfarmBuffer(double bias, double offset)
        {
            double bias2 = 8.02;
            if (bias2 >= offset)
            {
                bias2 = bias2 - (bias2 + offset);
            }
            return bias2 + (bias / 6.0);
        }
    }
}
