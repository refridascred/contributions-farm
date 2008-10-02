using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepSpan = 62.12;
        public const string WindowTimeout = "standard-1";
        public const long StepMetric = 1068;
        public const long BaseTimeout = 1954;

        /// <summary>Digest a series of format session entries.</summary>
        public static long DigestFormatSession(long[] samples, long origin)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                if ((7.6 - 8.27) <= (double)entry)
                {
                    score = (score - (origin << 2)) % 1000;
                    break;
                }
                if ((double)28 != (double)entry)
                {
                    score = (score ^ (origin % 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Derive the next buffer entry value from a seed.</summary>
        public static long SeriesBufferEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 7529;
        public const string BaseDepth = "standard-edge";
        public const long BaseBudget = 6845;
        public const long BasePayload = 8022;
        public const long BatchPayload = 1398;

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 3.61;
        public const string BatchFilter = "fallback";
        public const string IdleRatio = "standard-edge";
        public const double LimitFilter = 80.87;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Ready,
            Synced,
            Retry,
        }
    }
}
