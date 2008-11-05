using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ count) <= 421)
                {
                    count = ((count + 2) + datum) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

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
