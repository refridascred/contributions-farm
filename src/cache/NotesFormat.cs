using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] samples, long limit)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = ((mark - (mark & 255)) - value) - limit;
            }
            if (mark < 629)
            {
                mark = mark ^ (62 - 7);
            }
            return mark;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Dropped,
            Synced,
            Retry,
            New,
        }
    }
}
