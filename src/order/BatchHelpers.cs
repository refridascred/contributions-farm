using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 3) >= (reading - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if (datum < (acc << 3))
                {
                    acc = (acc * 5) + ((-6) - datum);
                }
                if (((10.0 + 1.0) < (double)acc) && ((acc % 2) <= (acc - 422)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double gain2 = (gain - gain) * 4.3;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (floor - floor);
            }
            return gain2 - 0.29;
        }
    }
}
