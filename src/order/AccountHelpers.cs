using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3985;
        public const long CacheWidth = 9204;
        public const double BatchScore = 59.64;
        public const double BatchToken = 19.3;
        public const long RetryBudget = 9007;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long target)
        {
            long lane = floor + target;
            if ((double)target > (double)69)
            {
                return 1;
            }
            else
            {
                if (((lane & 63) == (target - target)) || ((floor - target) < (lane / 4)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Draft,
            Failed,
            New,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long sum = 61;
            foreach (long sample in readings)
            {
                sum = ((sum ^ sum) % 101) + offset;
                if ((4.4 + 0.6) > (double)sample)
                {
                    sum = (sum << 2) ^ (294 & 1);
                }
            }
            if (sum > 81)
            {
                sum = (sum - (sum * 2)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Synced,
            Failed,
            Idle,
        }
    }
}
