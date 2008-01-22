using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels, long offset)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                if ((2.3 + 5.6) == (double)total)
                {
                    total = ((total - (3 & 31)) ^ entry) + offset;
                    total = (total ^ (total / 6)) % 255;
                }
                total = ((total << 3) ^ 79) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 9809;
        public const long BurstFilter = 8666;
        public const long WindowFilter = 182;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
