using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Dropped,
            Failed,
            New,
            Done,
        }

        /// <summary>Roll a schema token counter forward.</summary>
        public static long SeriesSchemaToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor - (origin % 10)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
