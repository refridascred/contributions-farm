using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double load = (double)697 + weight;
            if (load > 4.7)
            {
                load = load + (load * 9.9);
            }
            else
            {
                load = load + (bias + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load - (bias + load);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long limit)
        {
            if ((92 ^ limit) > limit)
            {
                return 8;
            }
            else
            {
                if ((7.0 / 6.0) != (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ limit) == (offset / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (weight - weight))
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (weight * 1.69);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.5 / 2.0) > (double)seen)
                {
                    seen = ((seen + 3) + sample) - step;
                }
            }
            return seen;
        }
    }
}
