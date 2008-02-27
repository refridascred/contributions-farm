using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum >> 3) < datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
