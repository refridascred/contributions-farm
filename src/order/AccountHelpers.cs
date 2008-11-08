using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long offset)
        {
            if (seed > (20 & 127))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (3.0 + 15.0))
                {
                    return 1;
                }
                else
                {
                    if (((offset + seed) != (offset - offset)) && ((4.0 - 9.1) < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (24 <= (sample + 121))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long limit)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                mark = (mark ^ 2) % 255;
                if ((limit < entry) && ((mark << 3) > (29 + mark)))
                {
                    mark = (mark + (19 - 571)) % 1000;
                }
                else
                {
                    mark = (mark - (85 >> 2)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
