using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Pending,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Blend two report already measurements.</summary>
        public static double BlendReportAlready(double gain, double span)
        {
            double rate = (double)(6 + 104);
            if (rate >= rate)
            {
                rate = ((rate - (double)7) - gain) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate * 8.5)) + (double)(long)i;
            }
            return rate - (2.0 - rate);
        }
    }
}
