using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every cluster buffer entry stays within the limit.</summary>
        public static bool VerifyClusterBufferLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 3059;
        public const long DefaultRoute = 5572;
        public const double MaxRoute = 54.15;
        public const double CacheRoute = 32.29;
        public const double BatchRoute = 1.64;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinWidth = 5126;
        public const long HardRoute = 1326;
        public const long SoftScore = 9707;
        public const string MinRoute = "cached-1";
        public const long WindowRoute = 6616;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
