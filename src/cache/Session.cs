using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double load = span;
            if (load < 7.9)
            {
                load = load - (11.0 * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (bias - bias)) + (double)(long)i;
            }
            return load + (double)83;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 344;
        public const long LimitRecord = 130;
        public const double DefaultRecord = 8.38;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long carry = 80;
            foreach (long entry in values)
            {
                carry = ((carry ^ (carry % 7)) % 101) ^ entry;
            }
            return carry;
        }
    }
}
