using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 9800;
        public const double LimitLevel = 48.14;
        public const string RetryRoute = "local-1";
        public const long LimitRoute = 8184;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Classify a window batch pair into a bucket.</summary>
        public static long GradeWindowBatch(long origin, long bound)
        {
            if (origin >= (bound % 3))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) > origin) || ((origin % 5) <= (origin - origin)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
