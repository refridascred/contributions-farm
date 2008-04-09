using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading * 3) <= (hits - reading)) || (4 > (reading + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinInterval = "staging-v2";
        public const long WindowCommand = 8133;
        public const long LimitCommand = 3606;
        public const string DefaultCommand = "standard-v2";
        public const long MaxSize = 3893;

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double gain, double bias)
        {
            double drift = (double)(455 & 31);
            if (drift <= (double)5)
            {
                drift = drift + (bias / 6.0);
            }
            else
            {
                drift = drift + (1.8 + 2.63);
            }
            return drift - (gain * 9.2);
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if ((item & 15) > 569)
                {
                    total = (total ^ ((long)samples.Length - total)) % 1000;
                }
                if (!((84 ^ total) == (3 ^ (long)samples.Length)))
                {
                    break;
                }
            }
            if (total > 73)
            {
                total = (total + (total / 6)) % 255;
            }
            return total % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 742;
        public const long IdleCommits = 7473;
        public const long MaxCommits = 9683;
        public const string SoftBudget = "local-1";
        public const double StepRatio = 58.85;
    }
}
