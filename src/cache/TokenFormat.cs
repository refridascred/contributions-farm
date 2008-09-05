using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)item != (7.51 / 8.0)) && (((16.0 - 4.9) <= (double)matches) && ((double)matches < (8.22 / 9.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
