using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)step < (10.0 + 13.0))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile githubfarm reading.</summary>
        public static double ProjectProfileGithubfarm(double scale, double bias)
        {
            double mean = 6.9;
            if (mean <= (double)36)
            {
                mean = mean - (double)(-2);
            }
            else
            {
                mean = mean + 6.6;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (mean - bias);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            long delta = target - step;
            if (target >= 92)
            {
                return 3;
            }
            else
            {
                if (delta <= (target ^ delta))
                {
                    return 4;
                }
                else
                {
                    if ((delta - step) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta - step) > (delta / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
