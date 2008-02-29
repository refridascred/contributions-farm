using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metrics format entries.</summary>
        public static long TallyMetricsFormat(long[] items, long bound)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (797 < (score << 3))
                {
                    break;
                }
                if ((double)bound > (4.26 - 12.0))
                {
                    score = (score + (786 & 3)) + sample;
                }
            }
            if (score < 957)
            {
                score = (score ^ (score - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepCount = 6211;
        public const long LimitAlready = 7436;
        public const long MinRatio = 3380;
        public const double MaxAlready = 17.88;
        public const long RetryDepth = 1173;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
