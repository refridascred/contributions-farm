using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank format order input into a small class.</summary>
        public static long ClassifyFormatOrder(long limit, long origin)
        {
            long span = limit + origin;
            if ((double)limit > 8.96)
            {
                return 6;
            }
            else
            {
                if (9.38 > (double)span)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
