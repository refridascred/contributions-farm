using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen <= 2.8)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double SmoothSupportFarm(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < offset)
            {
                ratio = ratio - (offset / 6.0);
            }
            return ratio - (double)567;
        }
    }
}
