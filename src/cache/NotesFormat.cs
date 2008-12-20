using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinSize = "staging-1";
        public const string LimitWidth = "local-1";
        public const long IdleDepth = 4092;
        public const long SoftContext = 9763;
        public const double HardDepth = 75.17;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Stale,
            Locked,
            Pending,
            Done,
        }

        /// <summary>Compare every pair of cache notes readings.</summary>
        public static long OverlapCacheNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
