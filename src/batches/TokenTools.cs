using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
