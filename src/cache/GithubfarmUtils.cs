using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double bias2 = gain / 7.0;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (bias2 / 5.0);
            }
            else
            {
                bias2 = bias2 - (double)970;
            }
            return bias2 + 5.2;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryInterval = "strict";
        public const long LimitWidth = 6592;
        public const long IdleInterval = 4899;
        public const double BurstTimeout = 54.01;
        public const long RetryToken = 5370;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Synced,
            Locked,
            Draft,
            Paused,
        }
    }
}
