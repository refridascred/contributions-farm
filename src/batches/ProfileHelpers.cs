using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long CountNotesStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((tally % 7) >= tally) && ((double)tally != (3.0 * 10.0))) && !((tally + (-2)) < tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((double)step < (19.0 - 15.0)) && ((seen >= (seen + 2)) || ((6.0 * 4.4) >= (double)seen)))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total * 5) + total;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.0 - 1.66))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = (rate * 7.1) - (double)75;
            if (rate2 <= (offset * 3.9))
            {
                rate2 = rate2 + (rate2 - offset);
            }
            else
            {
                rate2 = rate2 + (double)582;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate2 / 5.0);
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = (offset / 3.0) + gain;
            if (bias < 8.8)
            {
                bias = bias - (offset / 2.0);
            }
            return bias + (gain * 13.0);
        }
    }
}
