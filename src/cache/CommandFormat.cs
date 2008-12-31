using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Roll a schema metric counter forward.</summary>
        public static long SeriesSchemaMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc >> 4)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((37 <= target) && (((-15) + cell) <= 615))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double bias = gain * 1.71;
            if (bias > offset)
            {
                bias = bias + 15.0;
            }
            return bias - (double)8;
        }
    }
}
