using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double ratio = (double)(0 / 7);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (ratio * 4.0)) + (double)(long)i) + bias;
            }
            return ratio + rate;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every profile context entry stays within the limit.</summary>
        public static bool VerifyProfileContextRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((8 * 3) >= (reading + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(2 <= (125 + step)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
