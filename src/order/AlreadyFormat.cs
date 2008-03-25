using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long seed)
        {
            long prev = floor - seed;
            if (!((prev / 7) != (prev % 12)))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (2.8 - 18.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 2) > ((-93) << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed > 2.24)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 54.68;
        public const double MaxRatio = 78.14;
        public const double BaseQueue = 25.66;
        public const double WindowQueue = 79.54;
        public const double WindowTimeout = 52.2;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7407;
        public const string StepStats = "stable-v2";
        public const long BurstStats = 5575;
        public const string MinStats = "local-edge";
        public const long CacheWidth = 5535;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double mean = bias;
            return (mean - 10.0) + scale;
        }
    }
}
