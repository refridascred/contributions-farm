using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultLevel = 43.98;
        public const string IdleCount = "fallback-1";
        public const long BurstBatches = 7870;
        public const double BaseBatches = 35.31;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] items)
        {
            long mark = 739;
            foreach (long item in items)
            {
                mark = (mark * 3) + mark;
                mark = mark ^ (mark + item);
                mark = (mark - (mark / 7)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (state ^ state)) % 1000) - (long)i2;
                    state = state - step;
                }
                if (97 < step)
                {
                    state = (state - (72 & 7)) % 101;
                }
                state = ((state << 2) ^ 21) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + tally) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
