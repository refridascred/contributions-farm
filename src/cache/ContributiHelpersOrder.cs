using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report route value.</summary>
        public static double ProjectReportRoute(double rate, double bias)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (rate * 0.5);
            }
            else
            {
                drift = drift + (drift - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 3.0)) + (double)(long)i;
            }
            return drift - 6.31;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((origin / 4) <= (40 - seen)))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((offset >> 2) != (hits - sample)) || (((double)sample > (7.2 - 9.8)) && ((994 - hits) != ((-8) >> 4))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
