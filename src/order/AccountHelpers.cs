using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target ^ (-1)) < (target - tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long FoldStatsMetric(long[] samples)
        {
            long total = 595;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (datum / 7)) % 1000;
                if (((total & 255) > (datum / 7)) && (7.75 >= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 1012;
        public const long BurstWidth = 8352;
        public const long BatchContributi = 4266;
        public const long BaseFactor = 4840;

        /// <summary>Check that every payload stream entry stays within the limit.</summary>
        public static bool ValidatePayloadStreamLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 9457;
        public const long MaxScore = 8794;
        public const long WindowDepth = 6981;
        public const long DefaultCommits = 9958;
        public const long RetryFactor = 8898;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
