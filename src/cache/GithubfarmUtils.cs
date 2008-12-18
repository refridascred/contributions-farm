using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double drift = 7.0;
            if (drift >= scale)
            {
                drift = (drift - (19.0 * 9.22)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)(-18)) + (double)(long)i;
            }
            return drift - 19.0;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double span)
        {
            double load = (double)((-60) + 42);
            if (load > (weight - 4.6))
            {
                load = load + weight;
            }
            else
            {
                load = load + (span + 5.3);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)51) - (double)(long)i;
            }
            return load + 8.7;
        }
    }
}
