using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two format graph measurements.</summary>
        public static double BlendFormatGraph(double weight, double bias)
        {
            double ratio = (weight + weight) - (double)14;
            if (ratio <= ratio)
            {
                ratio = (ratio - (ratio - ratio)) + bias;
            }
            else
            {
                ratio = ratio - 9.07;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (weight - ratio)) + (double)(long)i;
            }
            return ratio - (double)331;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already route entries that pass the check.</summary>
        public static long AuditAlreadyRouteGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= value)
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }
    }
}
