using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long seed, long limit)
        {
            long cur = seed + limit;
            if ((9.1 * 5.6) <= (double)cur)
            {
                return 8;
            }
            else
            {
                if ((double)cur <= 1.77)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) < (limit % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed < (limit << 2)) || ((double)limit < (double)cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long floor)
        {
            if (8.7 > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((6.1 + 3.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - 32) > cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
