using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((bound + sample) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long bound)
        {
            long prev = limit + bound;
            if ((limit << 1) == (limit - prev))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) > (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((prev & 255) >= (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long CountBatchFilterOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((offset ^ 286) > hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
