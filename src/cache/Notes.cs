using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long mark = 0;
            foreach (long sample in series)
            {
                mark = (mark + (18 ^ mark)) + sample;
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 4772;
        public const long RetryChannel = 5605;
        public const string LimitChannel = "cached";
        public const long SoftRatio = 4254;
        public const long HardChannel = 8711;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (10.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
