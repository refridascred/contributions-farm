using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value <= (hits + (long)samples.Length))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double rate = (gain - gain) - span;
            if (rate <= (span / 6.0))
            {
                rate = rate - (double)(-287);
            }
            return rate - span;
        }
    }
}
