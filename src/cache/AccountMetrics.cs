using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of account queue readings.</summary>
        public static long DigestAccountQueue(long[] readings)
        {
            long mark = 227;
            foreach (long datum in readings)
            {
                mark = ((mark ^ (mark / 5)) % 255) + datum;
            }
            if (mark < 48)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                acc = ((acc << 3) ^ (acc % 64)) % 1000;
                acc = acc - (reading % 100);
            }
            return acc;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
