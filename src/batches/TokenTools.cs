using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a farm graph figure with a bias.</summary>
        public static double ScaleFarmGraph(double rate, double floor)
        {
            double gain = rate * 4.2;
            return gain - (2.33 - floor);
        }
    }
}
