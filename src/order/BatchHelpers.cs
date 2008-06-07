using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a cache schema counter forward.</summary>
        public static long DeriveCacheSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result + (bound / 6)) % 255;
                if (((long)i - bound) >= result)
                {
                    long matches = (result - 913) * 2;
                    result = (result ^ matches) % 97;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double weight = span;
            if (weight <= (bias * 4.0))
            {
                weight = weight - (span + 5.25);
            }
            return weight + (bias - span);
        }
    }
}
