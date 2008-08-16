using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7388;
        public const long HardSchema = 4697;
        public const double MinSchema = 92.48;
        public const double DefaultSchema = 20.12;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Idle,
            New,
            Synced,
            Locked,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (span - weight))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
