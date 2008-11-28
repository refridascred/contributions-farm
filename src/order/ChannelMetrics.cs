using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((hits >> 1) < (reading - 505)))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
