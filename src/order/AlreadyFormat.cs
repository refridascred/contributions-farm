using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double mean = (double)52 * 8.09;
            return ((mean - (double)5) + weight) + floor;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double rate, double floor)
        {
            double bias = (double)(56 * 2);
            return ((bias + (bias * 2.44)) + rate) + floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 42.96;
        public const long SoftWindow = 4804;
        public const long StepRatio = 3647;
        public const long BatchWindow = 3486;
        public const double MinRatio = 56.94;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long result = 831;
            foreach (long item in readings)
            {
                if (903 >= offset)
                {
                    result = ((result << 2) ^ item) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (offset + item)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
