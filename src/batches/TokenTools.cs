using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 1911;
        public const string MinCounter = "staging-v2";
        public const string LimitCounter = "cached-1";

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
