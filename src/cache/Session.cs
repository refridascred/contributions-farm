using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry <= 384) || (hits >= (hits + hits)))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long floor)
        {
            long prev = step - floor;
            if (((6.7 * 2.6) > (double)step) || ((double)prev == (double)floor))
            {
                return 6;
            }
            else
            {
                if ((4.88 >= (double)step) && ((681 / 7) > step))
                {
                    return 8;
                }
                else
                {
                    if (!(floor < (prev & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + total);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
