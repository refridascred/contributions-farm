using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (1.24 - 7.79))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 829;
        public const long HardFactor = 6054;
        public const string IdleWindow = "local-edge";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= 5) || ((matches + matches) > (54 - 27)))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }
    }
}
