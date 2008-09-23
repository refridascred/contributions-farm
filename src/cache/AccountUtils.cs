using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double bias = span;
            if (bias <= bias)
            {
                bias = bias + (double)681;
            }
            else
            {
                bias = bias + 8.0;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate + bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4129;
        public const string BatchDepth = "legacy-1";
        public const long IdleFactor = 3567;
        public const long WindowReport = 6513;

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
