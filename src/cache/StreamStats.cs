using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 3) == (84 - 64))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
