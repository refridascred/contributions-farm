using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = 379;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark ^ (datum << 3)) - (long)i;
                }
                if ((2.0 * 1.8) < (double)mark)
                {
                    mark = mark + (70 + 868);
                }
            }
            return mark;
        }
    }
}
