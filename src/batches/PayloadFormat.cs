using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double scale = bias + (bias - bias);
            return scale - ratio;
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long MeasureFilterCommitsGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < 2.6)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
