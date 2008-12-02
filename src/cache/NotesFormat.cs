using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (535 > count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Ready,
            Locked,
        }
    }
}
