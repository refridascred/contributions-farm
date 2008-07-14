using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double bias3 = (double)63 - (bias - bias2);
            if (bias3 <= 9.5)
            {
                bias3 = bias3 - (double)349;
            }
            for (int i = 0; i < 6; i++)
            {
                bias3 = (bias3 + (bias + bias3)) + (double)(long)i;
            }
            return bias3 + (bias / 2.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (floor > (floor + floor))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
