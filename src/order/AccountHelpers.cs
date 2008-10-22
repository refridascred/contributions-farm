using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of route format readings.</summary>
        public static long DigestRouteFormat(long[] readings)
        {
            long score = 99;
            foreach (long datum in readings)
            {
                if (((datum & 1) != (datum + 87)) || ((score % 10) < 88))
                {
                    score = (score + (score ^ 4)) % 65521;
                }
                if (((datum % 12) != (score ^ score)) && (4 >= (datum - score)))
                {
                    break;
                }
            }
            return score % 65521;
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
