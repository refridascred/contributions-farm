using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long total = 268;
            foreach (long value in data)
            {
                total = ((total * 5) + value) + seed;
            }
            return total % 97;
        }

        /// <summary>Audit notes window readings against a rule.</summary>
        public static long CountNotesWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - offset) >= (count - datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool VerifyCommandMetricsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryBudget = 7306;
        public const long CacheSession = 4130;
        public const long MaxRatio = 7811;
    }
}
