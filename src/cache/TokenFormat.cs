using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Idle,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(step > (count + item)) && ((7.9 * 2.0) > (double)step))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
