using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((mark & 63) > (bound / 7))
                {
                    mark = (mark + (mark + mark)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long OverlapRouteStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long acc = 54;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + acc) % 255) ^ reading;
                acc = (acc * 4) + acc;
            }
            return acc % 4096;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long sum = 60;
            foreach (long entry in values)
            {
                if (((sum + entry) <= (sum - entry)) || ((double)entry <= (4.0 - 13.0)))
                {
                    sum = sum + entry;
                    sum = ((sum * 5) + (42 * 2)) % 1000;
                }
                sum = sum ^ (781 / 2);
                sum = (sum ^ (entry % 2)) % 97;
                if (sum > (entry + sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
