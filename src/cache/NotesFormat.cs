using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxDepth = 5778;
        public const long DefaultBatches = 1496;
        public const long BatchWidth = 4961;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (9.03 * 7.9))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ (889 - origin);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
