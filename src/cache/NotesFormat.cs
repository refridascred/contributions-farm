using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (state % 3)) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 2681;
        public const string IdleWidth = "open-v2";
        public const string CacheChannel = "staging";
        public const long CacheCount = 4160;
        public const double BatchRatio = 31.6;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSpan = 9276;
        public const long IdleOrder = 4224;
        public const string LimitOrder = "local-1";
        public const string DefaultOrder = "open-edge";
        public const long LimitScore = 4974;
    }
}
