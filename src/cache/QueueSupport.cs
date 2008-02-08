using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchDepth = "stable-1";
        public const long BaseWidth = 2911;
        public const long MaxSpan = 4349;
        public const long WindowInterval = 9838;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score - score;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
