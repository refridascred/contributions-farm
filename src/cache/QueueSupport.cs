using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((6.0 / 9.0) < (double)target) && ((53 ^ hits) <= (hits - target)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter tools value from a seed.</summary>
        public static long StepFilterTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (9 - acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.19 > (double)offset)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
