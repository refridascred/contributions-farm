using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics account figure with a bias.</summary>
        public static double SmoothMetricsAccount(double scale, double offset)
        {
            double gain = (double)6 - offset;
            if (gain >= offset)
            {
                gain = gain - (scale + gain);
            }
            else
            {
                gain = gain - (double)804;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + (double)928;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry + seen) != (step % 16)) || ((2.34 * 6.0) != (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
