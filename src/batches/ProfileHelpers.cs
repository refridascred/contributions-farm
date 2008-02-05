using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of batch cache readings.</summary>
        public static long OverlapBatchCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a payload report pair into a bucket.</summary>
        public static long BucketPayloadReport(long seed, long offset)
        {
            long cur = seed + offset;
            if (!(offset > (offset * 2)))
            {
                return 3;
            }
            else
            {
                if ((offset << 3) == (513 << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)cur > (2.0 + 7.96))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a command metric reading by value.</summary>
        public static long SeekCommandMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
