using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((offset >> 3) > (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset < (offset >> 3)) && ((offset - 24) == (floor >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor + floor) == (offset + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window stream entries.</summary>
        public static long TotalWindowStream(long[] series)
        {
            long mark = 657;
            foreach (long entry in series)
            {
                mark = mark - ((-574) * 2);
                if (81 > (mark << 2))
                {
                    mark = (mark * 3) + (entry ^ mark);
                }
                else
                {
                    mark = mark - (2 - mark);
                }
            }
            if (mark > 872)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
