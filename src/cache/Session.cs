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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
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
