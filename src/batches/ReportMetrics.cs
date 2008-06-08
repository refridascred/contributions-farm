using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "staging";
        public const long DefaultGithubfarm = 7601;
        public const double BaseRatio = 62.45;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinTimeout = 8.22;
        public const double BurstRatio = 47.71;
        public const string MaxSchema = "standard";
        public const string MaxBudget = "stable";

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings, long origin)
        {
            long score = 2;
            foreach (long datum in readings)
            {
                if (((score >> 4) >= (score + datum)) || (origin >= (datum >> 2)))
                {
                    score = (score * 2) + 5;
                }
                else
                {
                    score = score - (origin / 7);
                    score = score - (score + origin);
                }
                score = ((score * 5) + (origin - (long)readings.Length)) % 65521;
                score = (score * 4) + (datum / 2);
            }
            if (score > (-927))
            {
                score = (score - (score + origin)) % 1000;
            }
            return score;
        }
    }
}
