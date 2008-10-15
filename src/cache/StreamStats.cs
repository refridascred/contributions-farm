using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (9.0 - 0.97))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (gain + floor)) + (double)(long)i;
            }
            return gain2 - (double)(-881);
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen >= (seen << 3)) || (9 <= (bound / 2)))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
