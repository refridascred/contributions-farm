using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Compare every pair of profile graph readings.</summary>
        public static long MatchProfileGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
