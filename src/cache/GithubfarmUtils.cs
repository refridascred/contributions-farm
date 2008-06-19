using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double mean = 3.1 * 7.33;
            for (int i = 0; i < 7; i++)
            {
                mean = (((mean + 10.0) + (double)(long)i) + gain) + offset;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Synced,
            New,
            Pending,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
