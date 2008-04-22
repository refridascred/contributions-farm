using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long target)
        {
            long score = -37;
            foreach (long cell in data)
            {
                if (cell < (score + target))
                {
                    score = (score << 2) ^ cell;
                }
                if (((score >> 1) > (cell % 3)) && (35 < (score - (-28))))
                {
                    score = ((score << 2) ^ (cell % 8)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
