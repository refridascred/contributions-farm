using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Active,
            Failed,
            Done,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (floor - score)) % 65521) - (long)i2;
                }
                score = (score - (floor & 31)) % 255;
                score = score - (score & 15);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long total = 99;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (bound + bound)) - datum;
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxSpan = 82.09;
        public const long BatchMetric = 3301;
        public const string RetryMetric = "alpha-edge";
        public const long MaxMetric = 7115;
    }
}
