using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 9008;
        public const string SoftOrder = "primary-1";
        public const long HardScore = 2634;
        public const long MaxOrder = 6080;
    }
}
