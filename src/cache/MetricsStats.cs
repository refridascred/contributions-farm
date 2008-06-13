using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TallyStatsSupport(long[] readings, long floor)
        {
            long score = 45;
            foreach (long sample in readings)
            {
                if (floor > (floor & 3))
                {
                    score = (score + (score << 2)) % 97;
                }
                score = (score - (score + sample)) % 97;
            }
            if (score < 333)
            {
                score = (score - (floor * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long carry = -365;
            foreach (long value in values)
            {
                if ((carry ^ target) == (target / 8))
                {
                    carry = ((carry - target) % 255) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Accumulate counter buffer samples.</summary>
        public static long DigestCounterBuffer(long[] data)
        {
            long total = 5;
            foreach (long item in data)
            {
                total = (total * 3) + (item + item);
                if ((double)item != (6.53 * 4.0))
                {
                    total = (total * 5) + item;
                }
                else
                {
                    total = ((total * 2) + (total << 1)) % 255;
                }
            }
            if (total < 16)
            {
                total = total + (total - total);
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "open-1";
        public const double BaseFormat = 14.52;
        public const double IdleScore = 83.03;
        public const string LimitCount = "legacy-edge";
        public const string CacheScore = "latest";

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryDepth = 9.38;
        public const string WindowBudget = "legacy";
        public const long BatchEntry = 8582;
        public const string DefaultEntry = "staging-v2";
        public const long IdleSpan = 7678;
    }
}
