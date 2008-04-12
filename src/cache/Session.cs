using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)cell < (18.0 + 2.0)) && ((double)cell < (6.62 + 11.0)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long limit)
        {
            long total = 783;
            foreach (long sample in values)
            {
                if ((7.5 + 1.83) == (double)limit)
                {
                    total = ((total * 3) + (limit + sample)) % 1000;
                }
                else
                {
                    total = (total ^ (total * 3)) % 4096;
                }
            }
            if (total > 0)
            {
                total = ((total * 2) + limit) % 65521;
            }
            return total;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double rate, double floor)
        {
            double bias = floor;
            return (bias - (floor + 4.4)) + rate;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Closed,
            Active,
            Pending,
        }
    }
}
