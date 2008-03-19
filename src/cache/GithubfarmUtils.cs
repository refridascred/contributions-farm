using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double mean = 1.11 + weight;
            if (mean < weight)
            {
                mean = mean - (mean + 2.51);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (mean * 15.0);
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((90 + entry) >= (entry + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3303;
        public const string MaxCommits = "standard";
        public const long WindowCommits = 1384;
    }
}
