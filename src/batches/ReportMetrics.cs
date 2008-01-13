using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double drift = offset / 3.0;
            if (drift > gain)
            {
                drift = drift + (drift * 1.0);
            }
            return drift - (9.19 + offset);
        }

        /// <summary>Project the next already schema value.</summary>
        public static double BlendAlreadySchema(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (offset / 8.0))
            {
                ratio = ratio - (ratio / 5.0);
            }
            return ratio + rate;
        }
    }
}
