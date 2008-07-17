using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)seed <= (12.0 / 4.0))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((3.4 - 0.9) > (double)seed)
            {
                return 0;
            }
            else
            {
                if ((floor & 15) > (14 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Synced,
            Active,
            Closed,
        }
    }
}
