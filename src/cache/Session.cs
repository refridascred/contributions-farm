using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Ready,
            Active,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 6917;
        public const long MinSize = 6020;
        public const string BatchTools = "cached-edge";
        public const long CacheSize = 1250;
        public const long MinTools = 3447;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
