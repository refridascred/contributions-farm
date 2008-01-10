using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "open-1";
        public const long BaseBudget = 5819;
        public const string SoftFarm = "cached-v2";
        public const double CacheSize = 54.9;
        public const double MinTimeout = 6.47;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] levels, long step)
        {
            long sum = 821;
            foreach (long cell in levels)
            {
                sum = ((sum * 4) + (sum / 4)) % 1000;
                sum = ((sum * 2) + (step + step)) % 1000;
                if (79 < step)
                {
                    sum = (sum ^ (cell + 81)) % 97;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series)
        {
            long mark = 891;
            foreach (long reading in series)
            {
                if (((7.4 - 7.5) >= (double)mark) && ((mark >> 5) < (mark * 5)))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 2) + (reading & 7)) % 101;
                }
                if (mark > (reading >> 2))
                {
                    mark = mark - (mark + reading);
                }
                else
                {
                    mark = (mark << 2) ^ (mark % 100);
                }
            }
            if (mark > 4)
            {
                mark = mark ^ (661 + mark);
            }
            return mark;
        }
    }
}
