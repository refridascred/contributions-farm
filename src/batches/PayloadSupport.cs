using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double mean = offset;
            if (mean >= scale)
            {
                mean = mean - (scale / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (offset * 11.0)) + (double)(long)i;
            }
            return mean - (offset - 7.5);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double drift = offset / 6.0;
            if (drift < (double)9)
            {
                drift = drift + gain;
            }
            return drift + gain;
        }
    }
}
