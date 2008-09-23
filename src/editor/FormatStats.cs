using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double rate = bias;
            if (rate > (scale / 7.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate + (double)386;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double weight, double span)
        {
            double gain = (double)(-799) + (double)125;
            return ((gain + (double)234) + weight) + span;
        }

        /// <summary>Scale a layout commits figure with a bias.</summary>
        public static double SmoothLayoutCommits(double bias, double floor)
        {
            double drift = 5.22;
            if (drift >= floor)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor - drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Project the next order command value.</summary>
        public static double ProjectOrderCommand(double ratio, double span)
        {
            double ratio2 = (5.3 * 0.4) * 18.0;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (span / 7.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (span / 6.0);
            }
            return ratio2 + ratio2;
        }
    }
}
