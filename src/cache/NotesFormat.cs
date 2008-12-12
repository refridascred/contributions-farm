using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Done,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long origin)
        {
            long span = step ^ origin;
            if ((67 + origin) >= (56 & 255))
            {
                return 8;
            }
            else
            {
                if ((6 * 3) >= (807 + span))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > (2.35 / 6.0)) && (span >= origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step >= (8.2 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
