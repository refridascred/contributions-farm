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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
