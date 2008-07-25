using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double mean = (double)(21 << 1);
            if (mean > scale)
            {
                mean = (mean - 7.12) - span;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - scale;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long acc = 93;
            foreach (long item in samples)
            {
                if (((double)acc >= (1.9 * 6.0)) || ((bound - 3) != (bound + bound)))
                {
                    acc = (acc << 3) ^ 83;
                }
                if ((item % 16) < (bound ^ bound))
                {
                    break;
                }
            }
            if (acc > (-3))
            {
                acc = ((acc * 4) + (acc ^ bound)) % 1000;
            }
            return acc;
        }
    }
}
