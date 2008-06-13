using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                long offset = 5 * 3;
                mark = ((mark * 2) + (offset - mark)) % 255;
                if ((5.2 * 4.5) <= (double)datum)
                {
                    mark = (mark ^ (long)readings.Length) % 97;
                }
                else
                {
                    mark = (mark * 4) + (-110);
                }
            }
            if (mark > 3)
            {
                mark = ((mark * 5) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (852 >= offset)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long TallyWindowQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!!((double)(-4) < (double)seen))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 259;
        public const long MinBatches = 2215;
        public const long LimitInterval = 5077;
        public const double CacheSize = 31.34;

        /// <summary>Classify a metric profile pair into a bucket.</summary>
        public static long BucketMetricProfile(long offset, long seed)
        {
            long lane = offset ^ seed;
            if ((seed + lane) != (lane & 3))
            {
                return 1;
            }
            else
            {
                if (((lane & 3) > offset) || (seed <= (offset + lane)))
                {
                    return 4;
                }
                else
                {
                    if ((23 >> 1) >= (seed + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed - lane) != (offset << 1)) && ((2.22 / 3.0) > (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
