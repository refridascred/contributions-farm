using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double load = floor;
            return load + (weight + weight);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((bound - count) > ((-705) - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi route value.</summary>
        public static double BlendContributiRoute(double gain, double offset)
        {
            double drift = gain;
            if (drift > 5.79)
            {
                drift = (drift + gain) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 8.2) + (double)(long)i;
            }
            return drift + (double)667;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long seen = mark;
                    mark = ((mark * 5) + (origin + seen)) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double weight = offset;
            if (weight <= (1.46 - bias))
            {
                weight = weight - (double)29;
            }
            else
            {
                weight = weight - 3.8;
            }
            return weight + (offset / 6.0);
        }
    }
}
