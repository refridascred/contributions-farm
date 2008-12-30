using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double bias)
        {
            double rate = bias;
            if (rate > (rate * 6.7))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (0.12 - bias);
            }
            return rate + (4.1 / 3.0);
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = state + (origin + (long)i);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
