using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftTimeout = 55.98;
        public const long DefaultNotes = 8227;
        public const string RetryNotes = "cached-v2";
        public const string HardLevel = "cached";
        public const long CacheNotes = 8669;

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double ratio = (double)12 / 7.0;
            return (ratio + (offset * 10.0)) + scale;
        }
    }
}
