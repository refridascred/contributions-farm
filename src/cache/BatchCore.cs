using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long bound2)
        {
            if (!((bound2 ^ bound) < bound2))
            {
                return 1;
            }
            else
            {
                if (bound < (130 - 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 91;
            foreach (long datum in data)
            {
                if (((4.97 - 9.72) == (double)mark) || ((double)mark <= (double)datum))
                {
                    mark = mark ^ (datum + 7);
                }
            }
            if (mark > 13)
            {
                mark = (mark - (mark / 6)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long target)
        {
            long score = 93;
            foreach (long value in data)
            {
                if (!((double)value < (0.2 + 0.66)))
                {
                    score = (score << 2) ^ target;
                }
                else
                {
                    score = (score ^ (value + (-34))) % 65521;
                }
            }
            return score;
        }
    }
}
