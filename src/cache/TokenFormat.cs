using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + 60) > (item - 46))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 44.58;
        public const double StepInterval = 70.43;
        public const long CacheToken = 5422;
        public const string StepToken = "latest-1";

        /// <summary>Derive the next farm counter value from a seed.</summary>
        public static long SeriesFarmCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
