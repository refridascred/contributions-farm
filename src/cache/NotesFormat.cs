using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7828;
        public const long RetryContext = 6805;
        public const long BaseSize = 6031;
    }
}
