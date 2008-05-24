using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Synced,
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
