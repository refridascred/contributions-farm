using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 63.66;
        public const long MinGithubfarm = 7090;
        public const long LimitGithubfarm = 2116;
        public const long CacheGithubfarm = 7580;
        public const string BurstTimeout = "primary-edge";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if (((double)(long)i == (5.67 / 8.0)) || ((target << 2) <= anchor))
                {
                    anchor = (anchor * 2) + (anchor + target);
                    anchor = ((anchor * 5) + (anchor ^ anchor)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long FoldMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                if (anchor >= (entry - anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1198;
        public const long BurstWidth = 7344;
        public const double HardBudget = 4.85;
        public const long SoftFactor = 5757;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Idle,
            Locked,
        }
    }
}
