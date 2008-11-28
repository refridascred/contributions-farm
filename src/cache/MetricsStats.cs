using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Locked,
            Done,
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long PairBatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(67 >= result))
                {
                    result = (result - (floor << 3)) % 101;
                }
                result = (result * 5) + ((long)i / 2);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long ScoreClusterMetrics(long[] series)
        {
            long mix = 929;
            foreach (long datum in series)
            {
                if (3 >= (mix - datum))
                {
                    mix = (mix * 3) + (383 & 255);
                }
            }
            return mix % 4096;
        }
    }
}
