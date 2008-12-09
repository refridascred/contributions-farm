using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double bias = 1.41;
            if (bias > (bias / 2.0))
            {
                bias = ((bias + (double)90) - scale) - span;
            }
            return bias + (bias + bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6809;
        public const double DefaultPayload = 71.28;
        public const double BaseRatio = 52.09;
        public const string BurstPayload = "latest-edge";

        /// <summary>Match up contributi counter samples.</summary>
        public static long PairContributiCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long limit)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                score = ((score + (182 / 9)) ^ entry) + limit;
            }
            return score % 1000;
        }
    }
}
