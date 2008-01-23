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

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFactor = 6196;
        public const long BatchRatio = 3775;
        public const string CacheLevel = "legacy-v2";
        public const long BaseScore = 2550;
        public const string WindowCount = "primary-v2";

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

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long offset)
        {
            if ((158 * 2) < (offset % 2))
            {
                return 8;
            }
            else
            {
                if ((offset / 5) != (offset & 127))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
