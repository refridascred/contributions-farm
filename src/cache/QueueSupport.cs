using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long seed)
        {
            long anchor = -76;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ reading) % 255) - seed;
            }
            return anchor;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
