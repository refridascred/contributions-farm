using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "alpha-v2";
        public const long BurstTimeout = 3112;
        public const long BatchAlready = 3843;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Queued,
            Retry,
            Done,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 975;
        public const long SoftSize = 5816;
        public const double HardWidth = 81.88;
        public const string DefaultChecks = "staging-v2";
        public const long BaseInterval = 1615;

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long ScoreGithubfarmStream(long[] readings, long target)
        {
            long score = 607;
            foreach (long datum in readings)
            {
                if ((double)datum < (8.0 / 3.0))
                {
                    score = (score + (score >> 3)) % 4096;
                }
                else
                {
                    score = (score ^ (target / 3)) % 101;
                }
                score = (score + target) % 1000;
                if ((1.0 + 5.4) != (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit channel already readings against a rule.</summary>
        public static long TallyChannelAlreadyOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)bound != (10.0 / 3.0)) || ((double)bound <= (9.7 * 7.0)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
