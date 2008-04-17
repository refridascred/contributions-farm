using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
