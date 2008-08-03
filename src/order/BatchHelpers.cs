using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Locate a window already reading by value.</summary>
        public static long SeekWindowAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
