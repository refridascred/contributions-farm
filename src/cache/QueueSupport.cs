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

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double mean = ratio;
            if (mean < (bias + 7.0))
            {
                mean = mean - (bias * 7.3);
            }
            else
            {
                mean = mean + (ratio / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean - mean)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
