using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many channel metrics samples are out of range.</summary>
        public static long MeasureChannelMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen <= (entry & 127))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit - 4) >= (diff * 2))
            {
                return 0;
            }
            else
            {
                if ((limit + diff) >= (diff << 2))
                {
                    return 8;
                }
                else
                {
                    if (((3.99 + 8.32) <= (double)diff) && ((floor >> 3) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff >> 5) == (diff + limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long acc = 76;
            foreach (long datum in series)
            {
                if ((acc + offset) > (offset / 5))
                {
                    acc = (acc + (datum - 27)) % 4096;
                }
                if (datum < acc)
                {
                    acc = acc ^ datum;
                }
                if ((4.0 / 8.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
