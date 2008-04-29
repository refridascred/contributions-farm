using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 82;
            foreach (long datum in samples)
            {
                if ((double)result == (16.0 / 8.0))
                {
                    result = result - (result ^ result);
                }
                if (((-542) >= (long)samples.Length) || ((double)datum <= (2.2 - 13.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double drift = bias;
            if (drift > (double)6)
            {
                drift = (drift + 3.0) - offset;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + (bias - 8.75);
        }

        /// <summary>Iterate the buffer farm series from a seed.</summary>
        public static long DeriveBufferFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
