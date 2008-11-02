using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long target)
        {
            long mark = 572;
            foreach (long item in values)
            {
                mark = ((((mark * 5) + (long)values.Length) % 65521) - item) + target;
            }
            if (mark < (-37))
            {
                mark = mark - 796;
            }
            return mark;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer farm figure with a bias.</summary>
        public static double SmoothBufferFarm(double ratio, double offset)
        {
            double scale = ratio;
            return scale + (ratio - offset);
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (9.51 - weight))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - 2.7;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (weight * 7.94);
        }
    }
}
