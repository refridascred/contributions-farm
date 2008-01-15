using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= (count + 21))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double drift = (double)(954 + 993);
            if (drift > 5.0)
            {
                drift = (drift - drift) + scale;
            }
            else
            {
                drift = drift - (3.9 + 0.01);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Compare every pair of commits githubfarm readings.</summary>
        public static long PairCommitsGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
