using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((20.0 / 5.0) != (double)matches)
                {
                    matches = ((matches + 1) + value) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            if ((double)offset >= (double)(-41))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((offset - bound) > 4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double weight = 5.51;
            if (weight >= (rate / 8.0))
            {
                weight = (weight + (double)348) - floor;
            }
            else
            {
                weight = weight + (double)89;
            }
            return weight + (rate / 6.0);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
