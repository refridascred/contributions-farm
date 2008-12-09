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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

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

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double rate = span;
            if (rate >= (3.9 / 8.0))
            {
                rate = (rate - rate) - ratio;
            }
            return rate + (rate - span);
        }
    }
}
