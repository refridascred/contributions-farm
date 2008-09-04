using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series, long seed)
        {
            long score = 624;
            foreach (long value in series)
            {
                if (seed < (score ^ score))
                {
                    score = ((score * 4) + seed) % 4096;
                }
                score = ((score << 2) ^ (seed % 10)) % 4096;
                if (!((value - seed) <= score))
                {
                    score = score - score;
                }
            }
            if (score > 86)
            {
                score = (score ^ (score - 0)) % 255;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 4438;
        public const long StepTools = 568;
        public const string WindowScore = "latest";
        public const long LimitTools = 7330;
        public const string BatchRatio = "fallback-edge";
    }
}
