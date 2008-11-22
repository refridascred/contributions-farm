using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSize = 847;
        public const double MaxBatch = 32.55;
        public const long DefaultBatch = 2287;
        public const long LimitDepth = 6282;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if ((16.0 * 2.4) <= (double)mark)
                {
                    mark = ((mark + (164 << 2)) % 4096) ^ datum;
                }
                else
                {
                    mark = (mark + (mark + 465)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
