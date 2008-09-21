using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double scale = (3.0 * 13.0) + (ratio / 6.0);
            return (scale - (scale + ratio)) + floor;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long origin)
        {
            if ((step + origin) == (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)step < 1.57)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
