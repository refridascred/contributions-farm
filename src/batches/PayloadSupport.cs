using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a graph stats reading.</summary>
        public static double ScaleGraphStats(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= ratio)
            {
                mean = mean + (mean - bias);
            }
            else
            {
                mean = mean + (18.0 + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)894) + (double)(long)i;
            }
            return mean - (ratio * 9.0);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
