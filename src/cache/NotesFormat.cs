using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchBudget = 6088;
        public const long DefaultSession = 1799;
        public const string SoftSession = "strict-v2";
        public const string RetryScore = "alpha";
        public const long BurstSession = 8987;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 7562;
        public const long LimitCluster = 7708;
        public const double SoftCluster = 67.94;
        public const double IdleCluster = 88.98;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
