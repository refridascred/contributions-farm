using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long anchor = -98;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (offset % 2)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 3328;
        public const long DefaultRatio = 1926;
        public const long IdleLevel = 1733;
    }
}
