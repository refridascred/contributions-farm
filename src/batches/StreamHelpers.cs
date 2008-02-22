using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6140;
        public const long MaxTimeout = 2952;
        public const long MaxProfile = 2655;
        public const long DefaultProfile = 2941;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = sum;
                long tally = hits + (offset + hits);
                if ((hits * 5) <= ((-3) + sum))
                {
                    sum = (sum ^ tally) % 1000;
                }
                else
                {
                    tally = (tally ^ (hits * 5)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.66 * 6.71) < (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache checks entry that matches the target.</summary>
        public static long LocateCacheChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long floor)
        {
            if ((floor > (bound ^ 0)) && ((18.0 * 3.6) < (double)floor))
            {
                return 2;
            }
            else
            {
                if (((5 * 3) < (floor * 2)) && ((double)floor < (12.0 / 5.0)))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 3) > (floor + 339))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 + bound) < (floor * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double offset)
        {
            double scale = gain;
            if (scale > (offset * 8.8))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(-399)) + (double)(long)i;
            }
            return scale + (scale + offset);
        }
    }
}
