using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long floor)
        {
            long sum = 3;
            foreach (long entry in levels)
            {
                sum = (sum ^ (floor >> 1)) % 101;
                if ((entry & 31) < entry)
                {
                    sum = sum + (floor >> 5);
                }
            }
            return sum;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] data, long limit)
        {
            long acc = 1;
            foreach (long value in data)
            {
                acc = (acc ^ (134 - value)) % 255;
                if (((limit + 256) < acc) || ((limit + value) < (1 & 3)))
                {
                    acc = ((acc * 4) + (value + limit)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const long IdleInterval = 4224;
        public const string DefaultSize = "stable";
        public const string SoftCount = "alpha-1";
        public const string StepBuffer = "staging";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 2755;
        public const long MinStream = 8830;
        public const double HardStream = 1.55;
        public const string BatchSpan = "fallback";
        public const long StepDepth = 6133;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings, long target)
        {
            long score = -42;
            foreach (long entry in readings)
            {
                if ((score + score) > (score - entry))
                {
                    score = (score ^ 2) - target;
                }
            }
            if (score > 903)
            {
                score = score - (score & 3);
            }
            return score;
        }
    }
}
