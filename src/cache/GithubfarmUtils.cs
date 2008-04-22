using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 2) != (floor << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mark = 16;
            foreach (long datum in readings)
            {
                if ((double)datum != (double)mark)
                {
                    mark = (mark << 2) ^ datum;
                    mark = ((mark * 5) + (datum + 203)) % 65521;
                }
                mark = (mark - (datum << 3)) % 255;
            }
            return mark;
        }
    }
}
