using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift / 4.0)) + (double)(long)i) - span;
            }
            return drift - (double)3;
        }
    }
}
