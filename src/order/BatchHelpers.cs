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

        /// <summary>Digest a series of report stats entries.</summary>
        public static long ScoreReportStats(long[] samples, long floor)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + state) <= (sample + floor))
                {
                    state = (state - (state + sample)) % 1000;
                }
                else
                {
                    state = state + (8 / 5);
                }
                if ((88 % 12) <= (sample << 3))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = state - state;
            }
            return state;
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
