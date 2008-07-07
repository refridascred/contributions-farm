using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next batches already value.</summary>
        public static double ProjectBatchesAlready(double ratio, double offset)
        {
            double scale = (0.91 * 4.49) - (ratio - offset);
            if (scale < offset)
            {
                scale = scale + (scale / 7.0);
            }
            else
            {
                scale = scale + (ratio * 9.51);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale - 0.3)) - (double)(long)i;
            }
            return scale + (ratio * 3.49);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheSpan = 2306;
        public const long IdleChecks = 3975;
        public const string RetryTimeout = "latest-edge";
        public const long LimitSize = 5581;
        public const double RetryChecks = 48.89;
    }
}
