using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a batches cache reading by value.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics counter measurements.</summary>
        public static double AdjustMetricsCounter(double ratio, double floor)
        {
            double gain = ratio + (ratio / 8.0);
            if (gain < gain)
            {
                gain = gain + (ratio + floor);
            }
            return gain + floor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Stale,
            Ready,
            Retry,
        }
    }
}
