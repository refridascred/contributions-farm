using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (floor * 3);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels)
        {
            long acc = 72;
            foreach (long value in levels)
            {
                acc = acc + value;
                if (((6 ^ acc) >= value) && (acc <= (94 / 3)))
                {
                    acc = acc - (acc ^ value);
                    break;
                }
                if (acc >= (8 - (long)levels.Length))
                {
                    acc = acc ^ (957 + acc);
                }
            }
            return acc;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
