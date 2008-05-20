using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (556 + mark)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
