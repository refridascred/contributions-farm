using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long anchor = 54;
            foreach (long value in levels)
            {
                if (value >= (anchor & 7))
                {
                    anchor = ((anchor ^ (63 + 57)) % 255) - limit;
                    anchor = ((anchor << 2) ^ 4) % 97;
                }
                if (((long)levels.Length << 1) < ((long)levels.Length + 133))
                {
                    anchor = (anchor + (value << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
            }
            return anchor;
        }
    }
}
