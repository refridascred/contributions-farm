using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches >= (7.69 / 4.0))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine token payload values into a single score.</summary>
        public static long FoldTokenPayload(long[] items, long target)
        {
            long score = 63;
            foreach (long reading in items)
            {
                if ((score + reading) <= (8 ^ reading))
                {
                    score = (score + (score % 8)) - target;
                }
            }
            return score % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 44.12;
        public const double StepTools = 13.42;
        public const long SoftBudget = 4601;
        public const long MaxTools = 5929;
        public const double HardTools = 76.58;
    }
}
