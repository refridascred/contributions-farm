using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double floor)
        {
            double gain = rate;
            if (gain <= rate)
            {
                gain = gain + (floor - gain);
            }
            else
            {
                gain = gain - (gain + 1.04);
            }
            return gain + (double)50;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= (offset + 2.1))
            {
                mean = mean - (offset / 7.0);
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 3.94) + (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
