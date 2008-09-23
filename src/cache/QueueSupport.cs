using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double drift = (gain * 8.3) - span;
            if (drift > 2.5)
            {
                drift = drift - (drift + span);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (drift / 3.0);
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
