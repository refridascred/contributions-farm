using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9754;
        public const long BaseWindow = 621;
        public const string DefaultFactor = "strict-v2";
        public const string CacheWindow = "strict-1";

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long state = 12;
            foreach (long cell in readings)
            {
                state = ((state ^ (state + state)) % 4096) + cell;
            }
            if (state < 4)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }
    }
}
