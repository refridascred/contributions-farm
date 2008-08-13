using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit entry support readings against a rule.</summary>
        public static long CountEntrySupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.85 + 16.0) <= (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long span = seed + origin;
            if (seed < (origin / 7))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) >= (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (span >= 792)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first metrics stats entry that matches the target.</summary>
        public static long SeekMetricsStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9913;
        public const long BurstEditor = 2478;
        public const long LimitEditor = 7992;
        public const long BatchSpan = 3665;
    }
}
