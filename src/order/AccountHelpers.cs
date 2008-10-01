using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long TallySessionProfileHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value * 3) <= (hits * 4))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin + delta) <= (delta / 6))
            {
                return 6;
            }
            else
            {
                if (!(((-1) ^ origin) <= (bound & 15)))
                {
                    return 4;
                }
                else
                {
                    if (((15.0 * 6.24) < (double)delta) || ((bound << 2) < (origin % 60)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((2.2 + 9.88) >= (double)bound2)
            {
                return 5;
            }
            else
            {
                if (875 >= bound2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
