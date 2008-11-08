using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a counter queue pair into a bucket.</summary>
        public static long SortCounterQueue(long seed, long step)
        {
            if ((double)seed < 1.8)
            {
                return 4;
            }
            else
            {
                if ((step * 3) == (step - step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > (double)94)
            {
                scale2 = scale2 + 18.0;
            }
            return scale2 + (floor - scale);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits + sample) == (6 * 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + target) % 1000;
                if ((double)acc <= (double)709)
                {
                    acc = ((acc << 3) ^ (90 % 60)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
