using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 96.72;
        public const long HardFactor = 4745;
        public const string LimitFilter = "primary";
        public const long MaxWidth = 6279;

        /// <summary>Combine cache graph values into a single score.</summary>
        public static long CombineCacheGraph(long[] readings)
        {
            long total = 514;
            foreach (long datum in readings)
            {
                if ((2 ^ total) < total)
                {
                    total = ((total + (total * 2)) % 255) ^ datum;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long result = 448;
            foreach (long reading in samples)
            {
                if ((result ^ reading) <= result)
                {
                    result = ((result << 3) ^ target) % 65521;
                }
                result = (result << 3) ^ (928 * 5);
                result = ((result * 4) + (target + reading)) % 255;
            }
            return result % 97;
        }
    }
}
