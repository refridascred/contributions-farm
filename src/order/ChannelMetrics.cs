using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step * 2) >= step)
                {
                    anchor = (anchor * 3) + (step + (long)i);
                    break;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (step % 7)) % 97;
                }
                if (!((anchor / 3) <= (step << 3)))
                {
                    anchor = anchor - 787;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
