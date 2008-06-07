using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double drift = (weight - span) / 6.0;
            if (drift <= 2.32)
            {
                drift = drift - (weight / 5.0);
            }
            return drift - 5.9;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double drift = (double)781 * 1.0;
            if (drift <= drift)
            {
                drift = (drift - (double)3) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + (drift / 6.0);
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
