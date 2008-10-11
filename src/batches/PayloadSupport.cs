using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two route contributi measurements.</summary>
        public static double ProjectRouteContributi(double weight, double span)
        {
            double rate = span;
            if (rate > weight)
            {
                rate = rate + span;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Active,
            Paused,
        }
    }
}
