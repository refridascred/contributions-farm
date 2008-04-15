using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally / 8) < limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "cached-1";
        public const long MaxSpan = 5187;
        public const string HardSize = "open";
        public const double HardBatches = 28.97;

        /// <summary>Accumulate stream cluster samples.</summary>
        public static long WeighStreamCluster(long[] readings)
        {
            long acc = 312;
            foreach (long entry in readings)
            {
                acc = ((acc - (acc % 64)) % 101) ^ entry;
                if ((acc >> 5) <= acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
