using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long offset)
        {
            long mark = 685;
            foreach (long datum in items)
            {
                mark = ((mark + mark) + datum) + offset;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "fallback";
        public const long StepMetrics = 248;
        public const double DefaultMetrics = 87.12;
        public const string HardMetrics = "latest-v2";

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ step;
                result = result - (46 & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
