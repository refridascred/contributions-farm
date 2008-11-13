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

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data, long step)
        {
            long state = 83;
            foreach (long value in data)
            {
                if ((double)value <= (double)413)
                {
                    state = ((state << 2) ^ (state + step)) % 1000;
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ (step + step)) % 255;
            }
            return state;
        }
    }
}
