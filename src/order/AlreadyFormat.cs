using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double load = floor + (double)499;
            return (load + (17.0 - floor)) + bias;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "staging-edge";
        public const double MaxFarm = 22.76;
        public const long LimitFarm = 8955;
        public const long RetryFarm = 303;
    }
}
