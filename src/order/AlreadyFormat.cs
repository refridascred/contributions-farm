using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long target, long origin)
        {
            if (62 > target)
            {
                return 0;
            }
            else
            {
                if (((-4) + 2) != (origin / 9))
                {
                    return 5;
                }
                else
                {
                    if ((645 >> 3) != (target << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = score - ((long)i << 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (20 > delta)
            {
                return 8;
            }
            else
            {
                if (((9.9 + 1.3) < (double)delta) && ((double)floor2 != (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items, long step)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                mark = (mark - cell) - step;
                if (mark > (cell << 1))
                {
                    mark = (mark ^ 652) % 101;
                }
            }
            if (mark > 162)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark % 65521;
        }
    }
}
