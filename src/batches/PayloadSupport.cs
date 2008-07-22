using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] items, long floor)
        {
            long total = 94;
            foreach (long sample in items)
            {
                total = ((total - (44 >> 4)) - sample) - floor;
            }
            return total;
        }

        /// <summary>Scale a notes payload figure with a bias.</summary>
        public static double AdjustNotesPayload(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = (bias2 - (double)733) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (double)612;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((bound << 2) < seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
