using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (double)13)
            {
                mean = (mean - mean) + bias;
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - (double)9;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
