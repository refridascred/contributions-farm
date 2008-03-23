using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseSpan = 4.55;
        public const long WindowStats = 6906;
        public const long DefaultStats = 625;
        public const long MaxStats = 1550;
        public const double BaseStats = 68.56;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Closed,
            Retry,
            Paused,
            Pending,
        }
    }
}
