using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((acc <= (long)i) || ((acc >> 5) > (acc + acc)))
                {
                    acc = ((acc << 2) ^ limit) % 97;
                    continue;
                }
                acc = acc - (acc * 5);
                if ((acc ^ acc) > (limit - limit))
                {
                    acc = (acc << 2) ^ ((long)i / 5);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen > (323 / 5))
                {
                    seen = ((seen + 1) + cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Dropped,
            Active,
            New,
        }
    }
}
