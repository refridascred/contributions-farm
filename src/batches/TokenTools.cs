using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
