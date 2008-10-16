using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double offset)
        {
            double load = bias + 3.9;
            if (load > offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (6.9 + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (load * 8.2);
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)datum == (double)8) || ((datum << 2) <= (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((6.25 + 7.13) >= (double)count)
                {
                    count = ((count + 1) + value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
