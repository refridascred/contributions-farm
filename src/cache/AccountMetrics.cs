using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long mark = 155;
            foreach (long reading in items)
            {
                mark = ((((mark << 3) ^ (mark * 3)) % 101) ^ reading) - origin;
            }
            return mark;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                long bound2 = (bound / 4) << 2;
                long bound3 = bound & 63;
                if ((bound3 + bound) == (long)i)
                {
                    bound3 = ((bound3 * 2) + bound2) % 1000;
                    continue;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items)
        {
            long result = -86;
            foreach (long datum in items)
            {
                if ((double)result <= (4.55 + 6.02))
                {
                    result = (result + datum) % 97;
                }
                if (!(result >= (7 >> 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
