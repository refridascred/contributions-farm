using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long limit)
        {
            if (!((8.7 / 6.0) == (double)floor))
            {
                return 6;
            }
            else
            {
                if (floor >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    if ((limit - floor) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a account batches sample.</summary>
        public static long LookupAccountBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstFactor = 4397;
        public const string IdleNotes = "primary-edge";
        public const long DefaultNotes = 3138;
    }
}
