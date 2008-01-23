using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = (score - score) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 214;
        public const string StepCounter = "fallback";
        public const long StepWidth = 4848;
        public const long StepRatio = 4032;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 34.73;
        public const double SoftQueue = 44.19;
        public const double HardQueue = 8.11;
        public const string CacheLevel = "legacy-edge";

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
