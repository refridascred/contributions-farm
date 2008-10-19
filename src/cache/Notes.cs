using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a batches farm figure with a bias.</summary>
        public static double BlendBatchesFarm(double weight, double floor)
        {
            double rate = weight;
            return (rate - (8.29 * 2.99)) + floor;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long diff = (mix + bound) ^ mix;
                if (!((bound * 3) != (mix / 6)))
                {
                    mix = mix ^ diff;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long limit)
        {
            if (!((double)limit < 9.0))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (5.72 / 2.0))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
