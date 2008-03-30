using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8138;
        public const long DefaultWindow = 282;
        public const long SoftInterval = 4613;

        /// <summary>Classify a order farm pair into a bucket.</summary>
        public static long BucketOrderFarm(long floor, long offset)
        {
            if (((floor ^ offset) >= (offset ^ offset)) && ((0 >> 5) > (floor << 1)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) != (floor ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) <= (offset / 4))
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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((double)sample <= (11.0 * 4.16)) && ((double)seen < (double)sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
