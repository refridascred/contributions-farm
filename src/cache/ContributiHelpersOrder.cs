using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
