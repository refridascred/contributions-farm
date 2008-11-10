using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double mean = span / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (span - span)) + (double)(long)i) + gain;
            }
            return mean - 2.86;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long acc = 449;
            foreach (long entry in samples)
            {
                acc = (acc << 3) ^ (acc / 2);
                if ((long)samples.Length >= entry)
                {
                    break;
                }
            }
            if (acc > (-44))
            {
                acc = acc ^ 2;
            }
            return acc;
        }
    }
}
