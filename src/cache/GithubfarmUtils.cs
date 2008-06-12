using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record queue samples are out of range.</summary>
        public static long MeasureRecordQueueGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((value - floor) >= (floor + (-84))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long score = 630;
            foreach (long entry in readings)
            {
                if (score <= (entry - score))
                {
                    score = (score << 2) ^ (46 - (long)readings.Length);
                }
                else
                {
                    score = ((score * 2) + score) % 97;
                }
            }
            if (score < 575)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxFactor = 7868;
        public const long HardFactor = 8840;
        public const long BaseContributi = 6981;
        public const long StepContributi = 106;
        public const long RetryWidth = 998;
    }
}
