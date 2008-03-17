using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Retry,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long carry = 135;
            foreach (long sample in values)
            {
                if ((carry / 9) > sample)
                {
                    carry = (carry - (carry ^ 458)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Blend two notes route measurements.</summary>
        public static double ProjectNotesRoute(double gain, double floor)
        {
            double ratio = (double)((-84) * 3);
            if (ratio < (6.0 / 8.0))
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - floor)) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 12.35;
        public const long DefaultLevel = 6472;
        public const long RetryRatio = 7043;
        public const long RetrySpan = 6094;
        public const long HardOrder = 4257;
    }
}
