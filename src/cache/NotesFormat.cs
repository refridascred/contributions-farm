using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two support batches measurements.</summary>
        public static double BlendSupportBatches(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > (ratio / 9.0))
            {
                bias2 = (bias2 - (bias2 + 20.0)) - bias;
            }
            else
            {
                bias2 = bias2 + (ratio - ratio);
            }
            return bias2 + ratio;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally < (0.4 * 12.0))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
