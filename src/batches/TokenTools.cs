using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long offset, long seed)
        {
            if ((7.58 / 5.0) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= (15.0 + 2.1)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Queued,
            Stale,
            Paused,
            Locked,
        }
    }
}
