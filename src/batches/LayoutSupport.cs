using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long seed)
        {
            long cur = target ^ seed;
            if ((double)seed > (4.0 * 7.2))
            {
                return 8;
            }
            else
            {
                if ((target % 8) <= (7 & 127))
                {
                    return 4;
                }
                else
                {
                    if (cur > (seed + 602))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 & 31) == (seed + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - origin) != (long)i)
                {
                    acc = (acc + (origin - (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) <= 8)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long TotalContributiFarm(long[] values, long target)
        {
            long result = 137;
            foreach (long item in values)
            {
                result = (((result << 3) ^ item) % 97) + target;
            }
            return result;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
