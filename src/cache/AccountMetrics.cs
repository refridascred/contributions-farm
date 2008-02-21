using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (seen * 4))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 97.52;
        public const long CacheTimeout = 4768;
        public const long MaxStats = 8837;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3237;
        public const long BaseSize = 2157;
        public const long HardChannel = 1624;

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 56;
            foreach (long cell in data)
            {
                if (63 <= (cell + 1))
                {
                    acc = acc + (cell % 12);
                }
            }
            return acc % 1000;
        }
    }
}
