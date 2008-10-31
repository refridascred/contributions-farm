using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long result = 510;
            foreach (long value in readings)
            {
                result = (result ^ value) % 1000;
                if ((value << 2) < (result / 2))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
