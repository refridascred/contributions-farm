using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of command cache entries.</summary>
        public static long TotalCommandCache(long[] values, long bound)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                acc = (acc - (bound + acc)) - reading;
            }
            return acc;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double drift = span;
            return (drift - span) + gain;
        }
    }
}
