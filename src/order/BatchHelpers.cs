using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((floor << 2) > (sample >> 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cache layout values into a single score.</summary>
        public static long TallyCacheLayout(long[] samples, long offset)
        {
            long acc = 614;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc * 2) + (item + (long)i)) % 4096) - offset;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc << 2) ^ (71 + item)) + (long)i2;
                }
                if (item > (item % 60))
                {
                    acc = (acc ^ item) % 255;
                }
            }
            return acc;
        }
    }
}
