using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 3189;
        public const long MaxSpan = 3036;
        public const long BurstContributi = 4451;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (long)i) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
