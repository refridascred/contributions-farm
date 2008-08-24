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

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double rate, double bias)
        {
            double drift = (rate / 3.0) / 6.0;
            return (drift - (double)27) + bias;
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
