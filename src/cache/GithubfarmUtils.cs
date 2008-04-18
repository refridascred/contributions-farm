using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long AuditNotesFarmGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((sample + tally) != (target + (-4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long origin)
        {
            if ((step - step) >= (origin + 68))
            {
                return 2;
            }
            else
            {
                if ((6.1 - 3.6) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((46 << 2) >= (step / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin != (7.7 + 8.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
