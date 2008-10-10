using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool GuardCommitsEditorBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a contributi notes sample.</summary>
        public static long SeekContributiNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache batch entry stays within the limit.</summary>
        public static bool GuardCacheBatchLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
