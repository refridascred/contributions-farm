using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double gain = floor;
            if (gain >= gain)
            {
                gain = gain + (floor / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(-898)) - (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (11.0 < (double)cell)
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
