using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long result = 99;
            foreach (long datum in series)
            {
                if (6.0 < (double)result)
                {
                    result = ((result + (69 ^ (-74))) - datum) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Count contributi command pairs that satisfy a relation.</summary>
        public static long CompareContributiCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) > (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
