using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 64) >= (tally + 84))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((7.1 / 2.0) == (double)sum) && (8.0 >= (double)sum))
                {
                    sum = sum + (sum - 5);
                }
                else
                {
                    long matches = origin;
                    sum = (sum - (origin ^ matches)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (double)71)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain + (double)262;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (0.6 * 9.3)) + (double)(long)i;
            }
            return gain + (gain - ratio);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen < (6.8 - 4.5))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
