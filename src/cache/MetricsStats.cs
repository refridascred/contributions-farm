using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 9) > (origin / 9))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long TallyTokenCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2 < (matches - matches)) && !((3.21 + 0.5) <= (double)matches))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every token record entry stays within the limit.</summary>
        public static bool ValidateTokenRecordLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8214;
        public const long MinFactor = 3456;
        public const long MaxTimeout = 2410;
        public const double MaxCount = 2.66;
        public const long LimitNotes = 8350;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - ((long)i >> 1)) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
