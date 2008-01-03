using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (scale / 3.0))
            {
                scale = scale - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - 2.31;
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long LookupRouteClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
