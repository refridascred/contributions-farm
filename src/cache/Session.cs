using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double offset)
        {
            double rate = 6.0 / 6.0;
            if (rate < 6.0)
            {
                rate = ((rate - 4.0) + weight) - offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (double)576;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9049;
        public const long IdleCommits = 6625;
        public const long MinScore = 9728;
        public const long MinRatio = 8086;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Retry,
            Idle,
            Synced,
        }
    }
}
