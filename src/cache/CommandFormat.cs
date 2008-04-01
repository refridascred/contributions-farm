using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches ^ 100) < (item % 16)) || (matches >= ((-628) + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout stream entries that pass the check.</summary>
        public static long CountLayoutStreamOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((seed + value) < (0 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-v2";
        public const string StepFarm = "stable";
        public const long RetryFarm = 8642;
        public const long LimitWidth = 7763;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double bias2 = rate * 2.2;
            if (bias2 > (double)(-12))
            {
                bias2 = bias2 + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
