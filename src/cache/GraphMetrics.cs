using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits & 3) > (93 + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long offset)
        {
            long sum = -604;
            foreach (long item in readings)
            {
                sum = (sum - (sum + item)) % 255;
                if ((0.61 * 5.07) == (double)offset)
                {
                    sum = (sum - (sum % 97)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long offset)
        {
            if (1 < (origin >> 3))
            {
                return 5;
            }
            else
            {
                if ((origin / 7) != (offset << 3))
                {
                    return 2;
                }
                else
                {
                    if ((5.7 / 2.0) <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + 643) == (offset % 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long OverlapChecksChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
