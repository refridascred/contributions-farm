using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)value == (1.41 * 4.0)) || (8.26 < (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i - 78);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long ScoreToolsCache(long[] readings)
        {
            long total = 247;
            foreach (long value in readings)
            {
                total = ((total - (total ^ total)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio * 7.2;
            if (weight > (double)38)
            {
                weight = (weight - weight) - floor;
            }
            return weight + weight;
        }

        /// <summary>Look up the position of a order support sample.</summary>
        public static long LookupOrderSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
