using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long limit)
        {
            if ((target + limit) >= (target + target))
            {
                return 8;
            }
            else
            {
                if (target >= limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long SeriesBufferRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((13 - offset) < offset)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            long lane = origin - step;
            if ((515 & 31) > (139 - lane))
            {
                return 0;
            }
            else
            {
                if (step > (origin + lane))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
