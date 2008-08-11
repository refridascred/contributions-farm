using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine session contributi values into a single score.</summary>
        public static long WeighSessionContributi(long[] items)
        {
            long mark = -351;
            foreach (long datum in items)
            {
                if (((datum % 24) >= (mark * 3)) || (mark > (datum / 2)))
                {
                    mark = (mark ^ (datum + mark)) % 65521;
                }
                else
                {
                    mark = (mark * 2) + (885 - mark);
                }
            }
            if (mark > (-7))
            {
                mark = mark ^ (mark / 2);
            }
            return mark;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long CountAlreadyPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 255) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
