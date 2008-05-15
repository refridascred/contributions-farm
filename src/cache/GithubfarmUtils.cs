using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 89;
            foreach (long value in data)
            {
                long slot = (value / 5) & 127;
                if (!((value - slot) <= value))
                {
                    score = ((score * 4) + (value - value)) % 101;
                    break;
                }
                if (((value + value) >= (score + 9)) && (0 > (score + value)))
                {
                    score = score + (value * 3);
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "open-v2";
        public const long MaxMetric = 6904;
        public const long WindowMetric = 8892;
        public const long BaseMetric = 6660;

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long AuditAccountContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value > 4.3)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
