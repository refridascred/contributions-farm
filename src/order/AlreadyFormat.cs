using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double gain = (double)(1 + 468);
            if (gain > gain)
            {
                gain = (gain - (double)(-985)) + bias;
            }
            return gain - (span / 9.0);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
