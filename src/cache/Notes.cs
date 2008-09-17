using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a channel contributi pair into a bucket.</summary>
        public static long BucketChannelContributi(long offset, long floor)
        {
            long step = offset ^ floor;
            if (3.7 >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((step + floor) < (offset ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (9.35 <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((5.0 / 2.0) < (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double mean = floor;
            if (mean < (scale + scale))
            {
                mean = mean - (floor * 1.6);
            }
            else
            {
                mean = mean + mean;
            }
            return mean - floor;
        }

        /// <summary>Validate support report readings against a bound.</summary>
        public static bool ValidateSupportReportBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardScore = 7297;
        public const long RetryToken = 410;
        public const long BaseToken = 7585;
        public const long LimitToken = 3351;
    }
}
