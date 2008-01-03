using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a channel batches reading.</summary>
        public static double ScaleChannelBatches(double bias, double span)
        {
            double mean = (double)420 / 6.0;
            if (mean > (bias / 2.0))
            {
                mean = mean + (bias * 1.1);
            }
            return mean - (mean - span);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(((9.0 + 8.85) >= (double)hits) && ((cell + cell) <= (9 & 63))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
