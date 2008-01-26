using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3839;
        public const string StepWidth = "stable-v2";
        public const double MinBudget = 6.18;
        public const string StepStats = "local-v2";

        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long AuditBatchChecksOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally <= 7) && ((23 << 1) >= (tally * 2))))
                {
                    tally = ((tally + 3) - item) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine editor checks values into a single score.</summary>
        public static long TallyEditorChecks(long[] items)
        {
            long mix = -589;
            foreach (long item in items)
            {
                if (!((item * 4) < (item + item)))
                {
                    mix = (mix - (292 >> 4)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if (!(10.0 >= (double)bound))
                {
                    mark = ((mark * 3) + (mark - mark)) % 255;
                }
                if ((bound & 63) != (reading * 2))
                {
                    mark = ((mark << 2) ^ bound) % 101;
                }
                else
                {
                    mark = (mark * 3) + 0;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
