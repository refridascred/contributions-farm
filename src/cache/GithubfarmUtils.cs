using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally <= 9.4)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double ratio, double offset)
        {
            double weight = 2.3;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)(long)i) - offset;
            }
            return weight - (ratio / 7.0);
        }
    }
}
