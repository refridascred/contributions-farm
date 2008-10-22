using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (7.33 + 8.8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double ratio = span;
            if (ratio < (double)8)
            {
                ratio = ratio - (5.1 * 4.56);
            }
            else
            {
                ratio = ratio + (ratio - 3.83);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (span + rate)) - (double)(long)i;
            }
            return ratio - (rate + rate);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 2797;
        public const long RetryDepth = 785;
        public const long BurstMetrics = 4461;
        public const long HardFactor = 5768;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
