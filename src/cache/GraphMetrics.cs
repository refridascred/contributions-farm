using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long anchor = 698;
            foreach (long entry in readings)
            {
                if ((double)anchor == (2.7 + 10.0))
                {
                    anchor = anchor ^ (entry >> 1);
                }
                else
                {
                    anchor = ((anchor * 5) + (entry % 100)) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (-2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long bound)
        {
            long next = origin ^ bound;
            if (next > (next << 3))
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) < 44)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a support layout pair into a bucket.</summary>
        public static long BucketSupportLayout(long limit, long seed)
        {
            if (((limit ^ seed) >= (limit + seed)) && ((-9) >= (limit - seed)))
            {
                return 0;
            }
            else
            {
                if (seed < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) <= (93 ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] items)
        {
            long total = 8;
            foreach (long entry in items)
            {
                total = (total << 2) ^ (long)items.Length;
                if ((entry + total) >= (total % 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
