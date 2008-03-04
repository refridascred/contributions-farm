using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                double mean = 2.86;
                if (!(18.0 > (mean - mean)))
                {
                    mark = ((mark << 2) ^ ((long)i * 4)) % 65521;
                    mean = mean - 8.2;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 255;
                    mark = mark + (97 % 5);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double rate = (double)(33 >> 1);
            if (rate > (floor / 7.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (7.25 + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - (double)7;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric channel figure with a bias.</summary>
        public static double BlendMetricChannel(double rate, double bias)
        {
            double mean = rate;
            return mean + bias;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
