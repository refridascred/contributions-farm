using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long step, long seed)
        {
            if (!((double)seed <= (8.9 / 9.0)))
            {
                return 2;
            }
            else
            {
                if (!((double)step < 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((585 * 2) > (seed % 60))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((591 ^ seed) >= 22)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const long StepEntry = 5922;
        public const long IdleEntry = 9624;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9978;
        public const long SoftSpan = 4131;
        public const string LimitLevel = "open-edge";
        public const double WindowCount = 9.56;
        public const double SoftSchema = 19.57;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double ratio = 4.7;
            return ((ratio + ratio) + bias) + floor;
        }
    }
}
