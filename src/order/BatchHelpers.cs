using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double bias)
        {
            double rate = bias;
            if (rate > (rate * 6.7))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (0.12 - bias);
            }
            return rate + (4.1 / 3.0);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 724;
            foreach (long item in samples)
            {
                if ((852 + result) >= (result + item))
                {
                    result = result - result;
                }
                else
                {
                    result = (result - (result >> 2)) % 4096;
                }
            }
            if (result < 166)
            {
                result = (result * 2) + 0;
            }
            return result;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
