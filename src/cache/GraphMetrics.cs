using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double gain2 = 20.0;
            if (gain2 < gain)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Draft,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long bound)
        {
            long step2 = step - bound;
            if (((5.7 + 4.0) == (double)bound) || ((step + 701) <= (step2 + step2)))
            {
                return 1;
            }
            else
            {
                if ((step2 - step2) > (step + bound))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next batches already value.</summary>
        public static double ScaleBatchesAlready(double bias, double span)
        {
            double ratio = (double)487 - bias;
            if (ratio <= (bias - bias))
            {
                ratio = (ratio + 15.0) - span;
            }
            return ratio - ratio;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
