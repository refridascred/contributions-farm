using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every graph batches entry stays within the limit.</summary>
        public static bool CheckGraphBatchesLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double ratio = bias - (double)0;
            if (ratio >= bias)
            {
                ratio = (ratio + (bias / 7.0)) + weight;
            }
            return ratio + 1.3;
        }

        /// <summary>Audit metric session readings against a rule.</summary>
        public static long MeasureMetricSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (seen << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
