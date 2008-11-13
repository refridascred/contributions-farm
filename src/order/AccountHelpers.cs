using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - 73) <= step)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a queue cache counter forward.</summary>
        public static long SeriesQueueCache(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                if (((result / 9) >= target) || ((double)result != (8.3 + 9.31)))
                {
                    result = result ^ (target ^ (long)i);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next commits account value.</summary>
        public static double ProjectCommitsAccount(double bias, double offset)
        {
            double scale = 4.0;
            if (scale > (scale - offset))
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token batch readings against a rule.</summary>
        public static long TallyTokenBatchGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally > 3.0)
                {
                    tally = ((tally + 3) ^ cell) + target;
                }
            }
            return tally;
        }
    }
}
