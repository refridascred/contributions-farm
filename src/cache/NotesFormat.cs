using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two route contributi measurements.</summary>
        public static double AdjustRouteContributi(double bias, double bias2)
        {
            double load = bias;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (double)873) + (double)(long)i) + bias2;
            }
            return load + (bias / 9.0);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (14.0 >= (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a window batch pair into a bucket.</summary>
        public static long GradeWindowBatch(long origin, long bound)
        {
            if (origin >= (bound % 3))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) > origin) || ((origin % 5) <= (origin - origin)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
