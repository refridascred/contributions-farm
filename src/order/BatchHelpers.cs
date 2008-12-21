using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long anchor = -9;
            foreach (long value in series)
            {
                if ((7 + anchor) > anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ value)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (target << 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double weight, double bias)
        {
            double scale = (double)((-69) - 9);
            if (scale > bias)
            {
                scale = (scale - (scale - 1.84)) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxDepth = 16.82;
        public const string MinBatches = "strict";
        public const long SoftFactor = 6304;
    }
}
