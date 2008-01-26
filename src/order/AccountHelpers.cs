using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next account commits value from a seed.</summary>
        public static long StepAccountCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((double)seed < (6.0 / 3.0)) && (seed > (seed << 2)))
                {
                    total = (total ^ (647 - seed)) % 101;
                }
                else
                {
                    total = total ^ (seed % 12);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
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
