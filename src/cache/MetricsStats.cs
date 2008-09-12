using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Derive the next command batches value from a seed.</summary>
        public static long StepCommandBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score ^ (origin / 6)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 4945;
        public const string MaxBudget = "legacy-1";
        public const long BaseGraph = 7241;
        public const double BurstGraph = 71.62;
        public const long RetryLevel = 9109;

        /// <summary>Accumulate contributi context samples.</summary>
        public static long DigestContributiContext(long[] values, long seed)
        {
            long sum = 246;
            foreach (long value in values)
            {
                sum = ((sum ^ (97 - value)) % 255) + seed;
                sum = sum + value;
            }
            if (sum > 823)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long target)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                if (((-6) ^ target) == (target / 2))
                {
                    sum = ((sum << 3) ^ (9 * 4)) ^ cell;
                }
            }
            return sum;
        }
    }
}
