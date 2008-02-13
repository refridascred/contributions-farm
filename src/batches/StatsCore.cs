using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((score >> 2) >= (5 - 40))
                {
                    score = ((score << 3) ^ score) % 1000;
                    score = (score * 3) + ((long)i << 3);
                }
                else
                {
                    score = (score * 5) + (score & 31);
                    score = (score + (bound + bound)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Draft,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Active,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxSize = "cached-edge";
        public const long IdleGithubfarm = 8799;
        public const long BurstScore = 621;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7205;
        public const double StepCounter = 88.29;
        public const long BatchInterval = 4692;

        /// <summary>Project the next command farm value.</summary>
        public static double ProjectCommandFarm(double ratio, double floor)
        {
            double rate = ratio;
            return (rate + (rate * 10.0)) + floor;
        }
    }
}
