using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 4983;
        public const string LimitBatches = "primary";
        public const double MaxRatio = 52.31;
        public const string WindowCount = "alpha-edge";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value < (6.2 * 5.8)) && ((18 + value) < (value - value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
