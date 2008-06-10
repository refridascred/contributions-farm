using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double mean = (1.52 * 4.0) + (6.1 - rate);
            if (mean < rate)
            {
                mean = mean - 4.65;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a format batches value against two limits.</summary>
        public static long SortFormatBatches(long step, long floor)
        {
            long span = step ^ floor;
            if (((step + floor) > (21 ^ 864)) || ((span % 16) > (10 + step)))
            {
                return 6;
            }
            else
            {
                if (48 < span)
                {
                    return 5;
                }
                else
                {
                    if ((double)step > 3.7)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ step) == (floor - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
