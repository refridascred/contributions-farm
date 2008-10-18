using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long offset)
        {
            long span = seed + offset;
            if ((offset - seed) != (span % 64))
            {
                return 0;
            }
            else
            {
                if (!(offset < (538 >> 2)))
                {
                    return 1;
                }
                else
                {
                    if ((41 << 1) > span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the window contributi series from a seed.</summary>
        public static long SeriesWindowContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 3) + ((long)i & 63);
                anchor = ((anchor << 3) ^ anchor) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every filter batch entry stays within the limit.</summary>
        public static bool CheckFilterBatchRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
