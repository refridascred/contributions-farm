using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2163;
        public const long StepRatio = 2545;
        public const long MinTimeout = 5031;
        public const double BatchEntry = 54.68;
        public const long MaxRatio = 8117;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long lane = bound - target;
            if ((bound + lane) < (6 - 266))
            {
                return 1;
            }
            else
            {
                if (8 >= (lane % 8))
                {
                    return 3;
                }
                else
                {
                    if ((target & 15) >= (bound ^ lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches - matches) == (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowRatio = 179;
        public const string BurstLevel = "fallback-v2";
        public const long IdleDepth = 7489;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((origin - sample) == (sample << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
