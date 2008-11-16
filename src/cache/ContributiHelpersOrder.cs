using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if ((floor % 3) == (961 >> 3))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) >= (7 - floor2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every batches commits entry stays within the limit.</summary>
        public static bool CheckBatchesCommitsLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
