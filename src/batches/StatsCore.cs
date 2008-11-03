using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) > (offset + offset))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values, long limit)
        {
            long anchor = -7;
            foreach (long datum in values)
            {
                anchor = (anchor - (anchor + datum)) + limit;
            }
            return anchor;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = mark ^ ((long)i % 24);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 4796;
        public const string BaseContext = "local-v2";
        public const long SoftCount = 1800;
    }
}
