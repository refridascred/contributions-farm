using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double mean = (floor - ratio) - floor;
            if (mean > (mean * 3.94))
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean - (ratio / 6.0);
            }
            return mean - (ratio - ratio);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1980;
        public const double LimitSession = 21.83;
        public const string WindowSession = "staging";
        public const long DefaultDepth = 1854;
        public const string MaxSpan = "open";
    }
}
