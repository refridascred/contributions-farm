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

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (weight - mean))
            {
                mean = (mean + mean) + offset;
            }
            else
            {
                mean = mean - (double)31;
            }
            return mean - (3.0 + weight);
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples, long target)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                anchor = (anchor - target) + entry;
            }
            return anchor % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "staging-edge";
        public const double MaxFarm = 22.76;
        public const long LimitFarm = 8955;
        public const long RetryFarm = 303;
    }
}
