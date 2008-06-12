using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2574;
        public const long BaseRoute = 533;
        public const long BaseSize = 4913;
        public const long BatchRoute = 5811;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long step)
        {
            long bound = origin - step;
            if ((origin ^ step) == (bound % 60))
            {
                return 8;
            }
            else
            {
                if ((double)step == (6.55 * 6.7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
