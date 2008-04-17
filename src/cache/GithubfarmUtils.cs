using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double weight = (double)(46 - 150);
            if (weight < (weight * 2.5))
            {
                weight = weight - (weight - bias);
            }
            else
            {
                weight = weight - (double)0;
            }
            return weight - (rate / 9.0);
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

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double mean = floor;
            if (mean >= (floor / 6.0))
            {
                mean = (mean + 6.0) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (2.35 - mean);
        }
    }
}
