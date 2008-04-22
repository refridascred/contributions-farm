using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load - (4.28 / 2.0);
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
