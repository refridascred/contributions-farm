using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Idle,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
