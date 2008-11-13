using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark ^ mark) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitDepth = 6133;
        public const long SoftWidth = 488;
        public const long CacheToken = 1003;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            New,
            Synced,
            Locked,
            Closed,
        }
    }
}
