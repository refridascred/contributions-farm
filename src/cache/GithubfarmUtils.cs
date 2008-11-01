using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary-v2";
        public const long MaxScore = 3082;
        public const long RetryMetric = 8534;
        public const long WindowLevel = 22;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 9275;
        public const long DefaultCounter = 4906;
        public const string BaseCounter = "strict-1";
        public const string BurstCounter = "fallback-1";

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long floor)
        {
            long diff = step - floor;
            if ((diff << 1) <= 130)
            {
                return 5;
            }
            else
            {
                if ((3.16 + 0.77) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((4.7 - 6.55) <= (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor ^ step) == (diff * 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < (bias * 7.2))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)(-893)) + (double)(long)i;
            }
            return ratio - (ratio + bias);
        }
    }
}
