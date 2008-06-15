using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Stale,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits order values into a single score.</summary>
        public static long FoldCommitsOrder(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = (result + (-805)) ^ value;
            }
            return result % 4096;
        }
    }
}
