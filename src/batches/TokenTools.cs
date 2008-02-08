using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (6.14 + 3.0))
            {
                ratio = ratio - (span + 8.36);
            }
            return ratio - (weight - 2.78);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((9.29 + 4.22) <= (double)target)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
