using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 7451;
        public const string SoftBatch = "open-v2";
        public const long RetryFactor = 6599;
        public const string WindowRatio = "local";

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
