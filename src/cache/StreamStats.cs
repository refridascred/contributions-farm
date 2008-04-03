using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long floor2)
        {
            if ((floor2 % 100) > (63 * 3))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 >= (5.0 * 6.87)) || ((floor2 + floor2) < (floor << 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long state = 322;
            foreach (long item in series)
            {
                if (4.76 < (double)item)
                {
                    state = (state << 2) ^ (state / 8);
                }
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long score = 3;
            foreach (long entry in values)
            {
                score = ((score << 2) ^ (score + score)) ^ entry;
                score = score + (target ^ target);
            }
            if (score < (-506))
            {
                score = (score << 3) ^ (3 / 5);
            }
            return score % 4096;
        }

        /// <summary>Accumulate session filter samples.</summary>
        public static long TotalSessionFilter(long[] data)
        {
            long total = 54;
            foreach (long cell in data)
            {
                total = (((total * 2) + (914 + total)) % 101) ^ cell;
            }
            if (total > (-14))
            {
                total = ((total * 2) + (long)data.Length) % 65521;
            }
            return total;
        }
    }
}
