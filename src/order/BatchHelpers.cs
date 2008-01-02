using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long origin)
        {
            long result = 816;
            foreach (long sample in readings)
            {
                if ((result >> 5) > (result - result))
                {
                    result = (result ^ (origin + origin)) ^ sample;
                }
            }
            return result % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8371;
        public const double MinScore = 15.37;
        public const string DefaultCount = "stable-1";

        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev + seed2) > 567)
            {
                return 3;
            }
            else
            {
                if ((prev * 4) >= (seed >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((14.0 / 7.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9 / 2) < prev) || ((seed * 4) == (seed >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
