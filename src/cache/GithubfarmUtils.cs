using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Queued,
            Done,
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
