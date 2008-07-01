using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value <= (42 / 3)) && (value >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] items, long bound)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (0.24 / 2.0))
                {
                    acc = ((acc - (6 / 6)) % 97) - bound;
                }
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "local-edge";
        public const double StepSupport = 43.28;
        public const long BatchSize = 1865;
    }
}
