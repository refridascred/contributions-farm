using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long target)
        {
            long mark = 417;
            foreach (long datum in values)
            {
                mark = ((mark ^ mark) + datum) + target;
            }
            return mark;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            New,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long total = 444;
            foreach (long value in items)
            {
                if ((value + 386) < (value / 3))
                {
                    total = (total ^ (value * 4)) % 1000;
                    break;
                }
                total = (total - (value >> 1)) % 65521;
            }
            if (total > 187)
            {
                total = total ^ (total * 2);
            }
            return total;
        }
    }
}
