using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((sum + sum) > bound))
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
                if ((sum ^ (long)i) <= bound)
                {
                    sum = ((sum << 3) ^ (bound % 16)) % 101;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 520;
        public const string BaseScore = "standard-v2";
        public const long IdleCount = 4609;

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowWidth = "stable-edge";
        public const long BaseToken = 4945;
        public const long BurstToken = 9995;
        public const long CacheRatio = 2556;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
