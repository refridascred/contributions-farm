using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long step)
        {
            long mix = 18;
            foreach (long sample in items)
            {
                mix = ((((mix << 3) ^ (283 / 4)) % 255) - sample) - step;
            }
            return mix;
        }

        /// <summary>Adjust a checks githubfarm reading.</summary>
        public static double SmoothChecksGithubfarm(double rate, double bias)
        {
            double bias2 = (double)2 - rate;
            if (bias2 < bias)
            {
                bias2 = bias2 + (bias2 - bias);
            }
            else
            {
                bias2 = bias2 + (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (double)255) - (double)(long)i;
            }
            return bias2 - rate;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Active,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "latest-v2";
        public const double MinRatio = 18.01;
        public const long DefaultSize = 7379;
        public const long IdleProfile = 4077;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series)
        {
            long state = -8;
            foreach (long item in series)
            {
                if ((23 - state) != (item + state))
                {
                    state = (state - (state + item)) % 1000;
                }
            }
            return state;
        }
    }
}
