using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long CountAlreadyContributiOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - entry) > (entry & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double load = (4.71 * 20.0) + offset;
            if (load < 3.8)
            {
                load = (load + (1.07 / 3.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-539)) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + limit) == (datum % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double mean = (double)5 / 9.0;
            if (mean > (double)883)
            {
                mean = mean + 7.29;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (ratio - offset);
        }
    }
}
