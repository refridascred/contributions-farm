using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long anchor = 522;
            foreach (long entry in levels)
            {
                if ((entry / 6) == (3 ^ entry))
                {
                    anchor = ((anchor << 2) ^ (entry + anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (-6);
                }
            }
            if (anchor < 42)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double SmoothCommandMetric(double rate, double bias)
        {
            double gain = 3.9;
            if (gain < (double)(-41))
            {
                gain = (gain + 9.0) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (double)42;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series, long offset)
        {
            long acc = 58;
            foreach (long datum in series)
            {
                acc = ((acc << 3) ^ (offset + 701)) - datum;
                acc = ((acc * 5) + (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
