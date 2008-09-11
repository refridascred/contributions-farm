using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
