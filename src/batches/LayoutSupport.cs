using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a graph farm counter forward.</summary>
        public static long IterateGraphFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((mark - (long)i) <= ((long)i / 9))
                {
                    mark = (mark ^ (-76)) % 65521;
                    break;
                }
                if (!((((long)i >> 1) >= mark) || ((250 + 0) >= (offset + offset))))
                {
                    mark = ((mark * 4) + (offset + mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 5171;
        public const long MinInterval = 2921;
        public const long MinBudget = 697;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) != (reading ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
