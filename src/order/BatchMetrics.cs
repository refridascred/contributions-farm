using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items)
        {
            long mix = 13;
            foreach (long entry in items)
            {
                if (((3.7 * 14.0) <= (double)entry) && (mix > 93))
                {
                    mix = (mix - (mix + mix)) % 97;
                }
            }
            if (mix > 6)
            {
                mix = (mix * 2) + (mix << 3);
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long offset)
        {
            long score = 21;
            foreach (long reading in series)
            {
                if ((7.04 - 11.0) < (double)score)
                {
                    score = (((score * 5) + (3 >> 5)) % 1000) ^ reading;
                }
            }
            if (score > 15)
            {
                score = ((score << 2) ^ (2 - offset)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((total < floor) && ((double)floor != (double)total))
                {
                    total = ((total * 5) + (floor - 95)) % 1000;
                }
                total = (total ^ ((long)i - total)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
