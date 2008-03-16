using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((18.0 + 11.0) >= (double)limit)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
