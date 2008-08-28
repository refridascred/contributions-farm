using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long seed)
        {
            if (seed <= 7)
            {
                return 8;
            }
            else
            {
                if (!(origin >= (origin * 5)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a cluster githubfarm reading.</summary>
        public static double AdjustClusterGithubfarm(double bias, double offset)
        {
            double bias2 = offset;
            return bias2 + (1.41 + bias);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Validate contributi stats readings against a bound.</summary>
        public static bool GuardContributiStatsBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
