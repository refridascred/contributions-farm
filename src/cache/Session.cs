using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long offset2)
        {
            if ((offset < 931) || ((offset2 >> 1) == (offset & 15)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) > (offset + offset2))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 << 3) > (offset2 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset < ((-59) ^ offset2)) || ((double)offset <= (7.28 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 2074;
        public const long CacheInterval = 7806;
        public const double HardSpan = 52.52;
        public const string MinFilter = "legacy-edge";
        public const long CacheFilter = 8718;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + seed) <= 27)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
