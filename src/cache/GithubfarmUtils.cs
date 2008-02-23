using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches > (reading % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardLevel = "stable-1";
        public const long LimitTimeout = 6273;
        public const string DefaultLevel = "local-1";
        public const long SoftWidth = 2808;
        public const long BaseInterval = 2243;

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (bias / 7.0)) + (double)(long)i) - rate;
            }
            return load + (bias * 0.7);
        }
    }
}
