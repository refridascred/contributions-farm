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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!(cell < (cell / 7)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
