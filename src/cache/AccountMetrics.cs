using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics stream readings.</summary>
        public static long FoldMetricsStream(long[] values)
        {
            long mix = 847;
            foreach (long sample in values)
            {
                if ((sample + mix) > sample)
                {
                    mix = (mix ^ (-3)) % 1000;
                }
            }
            if (mix > 804)
            {
                mix = mix - mix;
            }
            return mix % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitGithubfarm = "latest-v2";
        public const long MinScore = 4948;
        public const string RetryBudget = "local-1";
        public const long BaseGithubfarm = 9638;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7464;
        public const long IdleChannel = 3975;
        public const long BurstRatio = 2111;
        public const string WindowRatio = "stable-1";
        public const double StepFactor = 13.38;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 > ratio2)
            {
                ratio2 = ratio2 - (floor * 6.78);
            }
            else
            {
                ratio2 = ratio2 + (double)8;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + floor) + (double)(long)i;
            }
            return ratio2 + (double)94;
        }
    }
}
