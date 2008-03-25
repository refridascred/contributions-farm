using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7631;
        public const double HardSupport = 9.58;
        public const long CacheScore = 5894;
        public const long LimitScore = 9803;
        public const string LimitSupport = "primary-v2";

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long floor)
        {
            long step = origin + floor;
            if (step <= (floor & 255))
            {
                return 2;
            }
            else
            {
                if ((5.0 * 6.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double rate = (double)((-8) * 5);
            if (rate > rate)
            {
                rate = rate + (gain * 3.3);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + (bias / 6.0);
        }
    }
}
