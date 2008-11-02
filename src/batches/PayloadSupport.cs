using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long CountEntryCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value / 9) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long limit2)
        {
            if (((limit * 4) == (limit2 - 758)) || ((274 - limit2) >= limit))
            {
                return 6;
            }
            else
            {
                if (limit2 >= (limit2 + limit))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long origin)
        {
            long acc = -59;
            foreach (long datum in readings)
            {
                acc = (acc + (datum + origin)) % 4096;
                if (!((origin << 2) >= origin))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 97;
        }
    }
}
