using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double mean = 9.0;
            if (mean > (8.0 / 3.0))
            {
                mean = (mean + span) - rate;
            }
            return mean - (mean * 8.1);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((-9) / 7) > (sample & 1)) && ((tally + tally) != (tally >> 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double span)
        {
            double scale = span - (double)540;
            if (scale > scale)
            {
                scale = scale + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (weight / 4.0)) - (double)(long)i;
            }
            return scale - (scale * 3.0);
        }
    }
}
