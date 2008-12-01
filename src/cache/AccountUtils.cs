using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Closed,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((35 + bound) > (bound >> 2))
            {
                return 4;
            }
            else
            {
                if ((bound + offset) > (882 - offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset > (bound + bound)) && ((double)offset < (1.0 - 0.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
