using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                if (sum > (step + (long)i))
                {
                    sum = sum + (sum ^ sum);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.3;
        public const string HardCommand = "cached-1";
        public const long LimitCommand = 315;
        public const long SoftCommand = 5283;
        public const double BurstInterval = 47.5;
    }
}
