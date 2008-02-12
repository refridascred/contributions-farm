using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches notes entry stays within the limit.</summary>
        public static bool GuardBatchesNotesLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
