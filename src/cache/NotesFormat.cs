using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long origin)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if ((sample >= 0) && ((origin / 6) >= acc))
                {
                    acc = (acc + (acc + 7)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + origin) % 1000;
                }
                if ((616 + 0) <= (origin ^ origin))
                {
                    acc = ((acc * 5) + (origin - acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Closed,
            Stale,
            Done,
        }
    }
}
