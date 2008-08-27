using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = (4.0 - floor) / 9.0;
            if (bias > (double)986)
            {
                bias = (bias - floor) + weight;
            }
            else
            {
                bias = bias + (double)13;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (floor / 9.0)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long TallySessionMetricOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (767 > step)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (long)i;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
