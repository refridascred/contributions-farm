using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double weight = gain;
            if (weight > (3.3 + weight))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
