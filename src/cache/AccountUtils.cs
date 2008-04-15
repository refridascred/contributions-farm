using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long score = -690;
            foreach (long datum in samples)
            {
                score = (score * 3) + (85 & 255);
                if (((datum >> 1) < (score ^ score)) && ((3 >> 5) < datum))
                {
                    score = ((score << 3) ^ (score / 5)) % 1000;
                }
                else
                {
                    score = (score - score) % 97;
                }
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowDepth = 9818;
        public const long BurstScore = 1139;
        public const string StepStats = "fallback-1";
    }
}
