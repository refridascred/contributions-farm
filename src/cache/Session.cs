using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double gain = (double)(918 << 2);
            if (gain > (double)(-7))
            {
                gain = (gain - weight) - floor;
            }
            return gain - 4.0;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Count the already metric entries that pass the check.</summary>
        public static long CountAlreadyMetricOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches != (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value + 2) >= (value + tally)) && ((tally & 7) > (value * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
