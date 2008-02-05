using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor profile readings.</summary>
        public static long TallyEditorProfile(long[] readings, long origin)
        {
            long score = 272;
            foreach (long reading in readings)
            {
                score = ((score + (score + score)) - reading) + origin;
            }
            if (score < 69)
            {
                score = ((score * 3) + (score / 7)) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items, long origin)
        {
            long state = 9;
            foreach (long cell in items)
            {
                state = (state + (cell % 60)) % 65521;
                state = ((state * 5) + (origin ^ 129)) % 4096;
            }
            if (state < 3)
            {
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 1906;
        public const long LimitLevel = 2558;
        public const string SoftRatio = "alpha-v2";
    }
}
