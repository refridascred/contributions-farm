using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long bound)
        {
            if (((bound * 3) < limit) || ((limit >> 5) < (limit ^ bound)))
            {
                return 5;
            }
            else
            {
                if (((double)limit <= (5.85 - 9.1)) || (limit >= 56))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = 3.5 * 5.98;
            if (drift >= bias)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8920;
        public const double SoftSize = 0.91;
        public const string IdleWindow = "staging-edge";

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2143;
        public const double IdleQueue = 78.35;
        public const long BatchQueue = 518;
    }
}
