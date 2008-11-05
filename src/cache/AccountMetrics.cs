using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mix = 19;
            foreach (long value in levels)
            {
                if (!(mix < (mix >> 1)))
                {
                    mix = ((mix << 2) ^ (value & 15)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long floor)
        {
            if ((bound ^ bound) != (floor % 64))
            {
                return 2;
            }
            else
            {
                if (620 < (floor / 9))
                {
                    return 4;
                }
                else
                {
                    if (((-624) - bound) <= floor)
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

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 4286;
        public const double IdleSupport = 30.54;
        public const string BatchSupport = "primary-1";
        public const long HardSupport = 1376;
        public const long SoftSupport = 5968;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Stale,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Iterate the metric batch series from a seed.</summary>
        public static long SeriesMetricBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
