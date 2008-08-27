using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 629;
        public const long MaxScore = 1533;
        public const double LimitAlready = 95.86;
        public const double BurstAlready = 93.38;
        public const long BatchSpan = 7670;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 34.14;
        public const long MinGithubfarm = 6681;
        public const long LimitDepth = 8415;

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6251;
        public const long DefaultChannel = 8055;
        public const string MinChannel = "cached-edge";
        public const long RetryChannel = 3536;

        /// <summary>Scale a token account figure with a bias.</summary>
        public static double AdjustTokenAccount(double ratio, double span)
        {
            double bias = ratio - (double)493;
            if (bias >= (double)690)
            {
                bias = bias - (span + span);
            }
            else
            {
                bias = bias - (ratio * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) - (double)(long)i;
            }
            return bias + (span - 19.0);
        }
    }
}
