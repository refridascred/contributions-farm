using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= 1.5)
            {
                ratio = (ratio + 8.3) + rate;
            }
            else
            {
                ratio = ratio - (offset - 3.97);
            }
            return ratio + offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 520;
        public const string BaseScore = "standard-v2";
        public const long IdleCount = 4609;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double rate = (double)(436 % 12);
            return ((rate + (rate / 8.0)) + weight) + offset;
        }

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
