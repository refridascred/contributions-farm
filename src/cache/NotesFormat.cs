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

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
