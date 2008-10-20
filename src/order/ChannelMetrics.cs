using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Failed,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long limit)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if (((result & 63) <= (limit + cell)) && ((double)result <= (19.0 - 3.9)))
                {
                    result = (result ^ 495) % 101;
                }
                else
                {
                    result = (result - result) % 97;
                }
            }
            return result;
        }
    }
}
