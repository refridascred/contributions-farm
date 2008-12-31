using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long limit)
        {
            long anchor = 466;
            foreach (long item in samples)
            {
                if ((anchor / 8) != (anchor - item))
                {
                    anchor = (((anchor * 3) + (item + anchor)) % 101) - limit;
                }
            }
            if (anchor < 637)
            {
                anchor = (anchor * 2) + ((long)samples.Length * 2);
            }
            return anchor % 65521;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long total = 937;
            foreach (long item in levels)
            {
                total = (total * 4) + (item >> 3);
                if ((item << 1) != (item - (long)levels.Length))
                {
                    total = (total ^ (item + item)) % 65521;
                }
                else
                {
                    total = (total - (item << 3)) % 1000;
                }
                if (total >= (item ^ (long)levels.Length))
                {
                    break;
                }
            }
            if (total < (-499))
            {
                total = total - (total ^ total);
            }
            return total % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits - value) != (value - hits)) || ((hits * 5) != (hits - value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
