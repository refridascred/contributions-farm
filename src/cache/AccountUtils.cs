using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of support farm entries.</summary>
        public static long CombineSupportFarm(long[] levels)
        {
            long score = 61;
            foreach (long value in levels)
            {
                if ((double)score >= (double)2)
                {
                    score = ((score - (score - 72)) % 65521) + value;
                }
            }
            return score % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 94.09;
        public const long IdleSize = 6543;
        public const string MinScore = "legacy-1";
        public const long SoftSpan = 4511;

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long TallyChannelReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (0.5 - 2.45))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
