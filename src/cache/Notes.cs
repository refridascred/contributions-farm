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

        /// <summary>Roll a farm metric counter forward.</summary>
        public static long StepFarmMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((limit * 4) == (result - limit)))
                {
                    result = (result ^ ((long)i >> 5)) % 101;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySize = "legacy-1";
        public const long DefaultCount = 434;
        public const long DefaultTimeout = 7691;
        public const string IdleSize = "primary-v2";
        public const long RetryLevel = 4234;
    }
}
