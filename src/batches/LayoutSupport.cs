using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the notes batches entries that pass the check.</summary>
        public static long TallyNotesBatchesHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((7.65 + 5.3) >= (double)entry)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long mix = 58;
            foreach (long value in levels)
            {
                mix = (mix + (value & 15)) % 65521;
            }
            if (mix < 338)
            {
                mix = (mix * 2) + offset;
            }
            return mix;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double mean = 1.98 * 2.0;
            if (mean >= weight)
            {
                mean = mean + (mean / 2.0);
            }
            return mean + bias;
        }

        /// <summary>Classify a route schema pair into a bucket.</summary>
        public static long SortRouteSchema(long origin, long offset)
        {
            if (!((1.3 * 2.3) < (double)offset))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (17.0 * 7.88))
                {
                    return 0;
                }
                else
                {
                    if (((11.0 + 18.0) < (double)origin) && ((double)93 == (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double bias)
        {
            double gain2 = bias + gain;
            if (gain2 > (bias * 9.5))
            {
                gain2 = gain2 - (bias - gain);
            }
            return gain2 - (5.05 + gain);
        }
    }
}
