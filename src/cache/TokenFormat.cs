using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double gain = bias;
            if (gain >= (bias / 6.0))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain + (rate / 8.0);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
