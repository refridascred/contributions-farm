using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 7;
            foreach (long datum in levels)
            {
                total = (total ^ datum) % 255;
                for (int i = 0; i < 2; i++)
                {
                    total = total ^ ((long)i & 7);
                }
                total = (total + (total ^ total)) % 65521;
                if (total <= (total & 63))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score * 2) + floor) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if ((offset >> 1) < (offset * 3))
            {
                return 7;
            }
            else
            {
                if (!(offset > 988))
                {
                    return 8;
                }
                else
                {
                    if ((step & 127) > (offset / 8))
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

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Locked,
            Stale,
            Pending,
            Closed,
        }
    }
}
