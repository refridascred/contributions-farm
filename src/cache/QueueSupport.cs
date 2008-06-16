using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm queue readings against a rule.</summary>
        public static long MeasureGithubfarmQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) >= (4 % 24))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item / 2) > (835 - tally))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double drift = floor - gain;
            if (drift >= (double)65)
            {
                drift = drift - (double)5;
            }
            return drift - gain;
        }
    }
}
