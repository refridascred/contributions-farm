using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double ratio = gain;
            if (ratio < (15.0 - span))
            {
                ratio = ratio - (double)(-51);
            }
            else
            {
                ratio = ratio - (gain * 2.8);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio - (ratio / 8.0);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
