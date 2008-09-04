using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batch commits measurements.</summary>
        public static double AdjustBatchCommits(double rate, double floor)
        {
            double mean = (double)(2 / 2);
            if (mean >= (double)1)
            {
                mean = ((mean - (double)691) - rate) - floor;
            }
            return mean - (double)5;
        }

        /// <summary>Match up already tools samples.</summary>
        public static long MatchAlreadyToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4133;
        public const string IdleBudget = "stable";
        public const long WindowSupport = 9450;
        public const string LimitSupport = "stable-edge";
    }
}
