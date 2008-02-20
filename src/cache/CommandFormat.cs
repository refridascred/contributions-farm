using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double gain = (double)43 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + 5.8) + (double)(long)i) - bias;
            }
            return gain - (floor * 0.19);
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Draft,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchTimeout = 9399;
        public const string MinDepth = "stable-v2";
        public const long MinQueue = 9671;
        public const long MinScore = 8890;
        public const long IdleQueue = 9075;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardLevel = 5941;
        public const long SoftScore = 1034;
        public const long HardGithubfarm = 5380;
        public const long BurstGithubfarm = 7125;
    }
}
