using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double weight = ratio;
            return (weight - ratio) + floor;
        }

        /// <summary>Find the first buffer window entry that matches the target.</summary>
        public static long SeekBufferWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 8591;
        public const long BatchTools = 2530;
        public const string MinSize = "strict-1";
    }
}
