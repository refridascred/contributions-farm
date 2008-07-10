using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long bound)
        {
            if ((3.1 / 3.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if (((seed - seed) <= 5) || ((double)bound <= (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Failed,
            Retry,
            Active,
            Ready,
        }
    }
}
