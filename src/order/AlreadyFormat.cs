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

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
