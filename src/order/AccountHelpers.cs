using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long TotalSchemaContributi(long[] series, long target)
        {
            long total = 8;
            foreach (long value in series)
            {
                if (target <= (total + target))
                {
                    total = (total - (value * 4)) % 65521;
                }
                else
                {
                    total = (total ^ (858 + target)) % 1000;
                }
            }
            if (total < 61)
            {
                total = (total * 2) + (total + total);
            }
            return total;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            if (target < seed)
            {
                return 5;
            }
            else
            {
                if (9.0 > (11.0 - 12.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a commits contributi reading by value.</summary>
        public static long LookupCommitsContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
