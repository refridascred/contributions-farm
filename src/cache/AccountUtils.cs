using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of notes route entries.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (state * 4)) - entry;
            }
            if (state > 798)
            {
                state = ((state * 3) + 837) % 4096;
            }
            return state;
        }
    }
}
