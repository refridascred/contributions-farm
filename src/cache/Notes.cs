using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values)
        {
            long mark = 390;
            foreach (long entry in values)
            {
                mark = ((mark - (mark % 5)) % 97) + entry;
                if ((mark % 10) <= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 62.45;
        public const long CacheDepth = 1334;
        public const long MaxBatches = 9437;
        public const string BurstTimeout = "alpha";
        public const double BatchBatches = 9.73;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 709;
            foreach (long cell in values)
            {
                if (!((double)cell != (4.1 / 9.0)))
                {
                    acc = acc ^ (acc << 2);
                }
                if (((cell + cell) > cell) || ((double)acc != (0.8 / 4.0)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySize = "legacy-1";
        public const long DefaultCount = 434;
        public const long DefaultTimeout = 7691;
        public const string IdleSize = "primary-v2";
        public const long RetryLevel = 4234;
    }
}
