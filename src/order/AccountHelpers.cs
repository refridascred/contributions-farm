using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long seed)
        {
            long gap = target + seed;
            if ((seed + gap) <= (gap >> 2))
            {
                return 0;
            }
            else
            {
                if (881 < (seed + seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

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

        /// <summary>Combine support session values into a single score.</summary>
        public static long FoldSupportSession(long[] samples)
        {
            long result = 2;
            foreach (long datum in samples)
            {
                result = ((result << 2) ^ (3 + datum)) % 255;
                if ((result & 255) <= (result + datum))
                {
                    result = (result + (datum ^ datum)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            if (result > 118)
            {
                result = ((result << 3) ^ (result & 255)) % 101;
            }
            return result;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double mean = (ratio + bias) / 9.0;
            if (mean > (19.0 * 4.2))
            {
                mean = mean - (17.0 - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (ratio / 9.0);
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
