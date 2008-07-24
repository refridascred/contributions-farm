using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long step)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                mark = (((mark ^ (mark / 6)) % 97) + datum) + step;
                if ((mark % 16) < ((long)readings.Length & 127))
                {
                    mark = (mark << 3) ^ (mark % 97);
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (mark >> 2);
            }
            return mark;
        }

        /// <summary>Look up the position of a graph filter sample.</summary>
        public static long FindGraphFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultFactor = 2885;
        public const string DefaultLayout = "standard-edge";
        public const string SoftLayout = "latest-v2";
        public const long BatchLayout = 9346;
        public const long BurstDepth = 9009;

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 13.9;
        public const long LimitFactor = 7520;
        public const string WindowSize = "standard-1";
        public const string WindowTimeout = "fallback-v2";
        public const long RetryOrder = 7012;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
