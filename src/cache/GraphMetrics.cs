using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = 85;
            foreach (long item in data)
            {
                if (mark <= (item & 31))
                {
                    mark = (mark ^ 4) % 97;
                }
                else
                {
                    mark = (mark ^ (mark / 7)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 3629;
        public const long WindowStats = 2932;
        public const long RetryInterval = 1322;
        public const long BatchStats = 1513;
        public const double MaxStats = 60.0;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheDepth = "staging-v2";
        public const long MinCommand = 7390;
        public const long RetryCommand = 3678;
        public const long SoftTimeout = 984;
        public const double BaseCommand = 31.63;
    }
}
