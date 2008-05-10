using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value != (double)63)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Locked,
            Pending,
            Done,
        }
    }
}
