using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long floor)
        {
            long score = 5;
            foreach (long value in samples)
            {
                score = (((score << 2) ^ value) % 4096) + floor;
            }
            return score;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Ready,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary";
        public const double LimitContributi = 50.62;
        public const string HardContributi = "alpha-v2";
    }
}
