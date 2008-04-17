using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double bias = rate;
            if (bias > (bias * 6.8))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 1.0) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)16 == (double)offset)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate queue entry readings against a bound.</summary>
        public static bool GuardQueueEntryLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double weight = 17.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)(long)i) - ratio) - span;
            }
            return weight + (weight + 7.3);
        }
    }
}
