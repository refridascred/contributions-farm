using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "local-1";
        public const long WindowChannel = 391;
        public const long RetryTimeout = 6663;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double load = bias;
            return (load - (double)634) + weight;
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long ScoreStatsGithubfarm(long[] readings, long origin)
        {
            long result = 978;
            foreach (long value in readings)
            {
                result = (((result * 4) + origin) % 1000) - value;
                result = result + origin;
            }
            return result;
        }
    }
}
