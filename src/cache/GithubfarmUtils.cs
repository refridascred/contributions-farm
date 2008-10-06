using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of batch support entries.</summary>
        public static long WeighBatchSupport(long[] items)
        {
            long acc = 98;
            foreach (long cell in items)
            {
                acc = acc ^ (3 / 5);
                if (cell <= (668 + cell))
                {
                    acc = acc ^ (cell - cell);
                }
            }
            if (acc < 8)
            {
                acc = ((acc << 2) ^ (acc % 10)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
