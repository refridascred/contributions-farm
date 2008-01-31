using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long seed)
        {
            long lane = origin - seed;
            if ((seed ^ lane) >= (5 - seed))
            {
                return 6;
            }
            else
            {
                if ((seed ^ seed) <= (18 - lane))
                {
                    return 8;
                }
                else
                {
                    if (seed < (lane + 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed != (1.1 * 1.7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long target)
        {
            long state = 943;
            foreach (long value in series)
            {
                if ((value - state) <= target)
                {
                    state = ((state * 4) + (value - target)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (72 + state);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
