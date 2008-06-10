using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4185;
        public const long CacheBudget = 5503;
        public const double StepSize = 57.88;
        public const double IdleSpan = 30.77;
        public const double SoftRoute = 38.05;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count * 4) <= (limit & 127))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (418 * 3)) % 101;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Paused,
            Stale,
            Locked,
            Synced,
        }
    }
}
