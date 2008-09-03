using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double AdjustChannelEntry(double scale, double floor)
        {
            double bias = (double)((-31) % 12);
            if (bias <= scale)
            {
                bias = (bias - scale) - floor;
            }
            else
            {
                bias = bias + (bias - bias);
            }
            return bias + scale;
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((15.0 <= (double)hits) || (((double)entry == (double)target) && ((double)entry != (4.66 / 2.0))))
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
