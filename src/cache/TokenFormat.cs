using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor route entry stays within the limit.</summary>
        public static bool VerifyEditorRouteRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
