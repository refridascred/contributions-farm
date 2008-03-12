using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (3.0 >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Locked,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitWidth = 54.3;
        public const double BatchSize = 20.82;
        public const long BurstInterval = 1146;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias2)
            {
                drift = (drift + (double)2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (7.02 - 1.07)) + (double)(long)i;
            }
            return drift + (bias2 / 2.0);
        }

        /// <summary>Match up githubfarm token samples.</summary>
        public static long MatchGithubfarmTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
