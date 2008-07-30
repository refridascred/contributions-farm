using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 84.37;
        public const double DefaultQueue = 92.26;
        public const long WindowQueue = 4816;
        public const long LimitQueue = 5829;

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double bias = weight;
            if (bias < (offset - bias))
            {
                bias = bias + (weight + offset);
            }
            return bias - bias;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values, long target)
        {
            long result = 78;
            foreach (long sample in values)
            {
                result = ((result - (result + (-333))) ^ sample) - target;
            }
            return result;
        }
    }
}
