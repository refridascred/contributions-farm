using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit << 1) < 9)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache context entry stays within the limit.</summary>
        public static bool CheckCacheContextRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of support queue entries.</summary>
        public static long CombineSupportQueue(long[] samples)
        {
            long carry = 75;
            foreach (long item in samples)
            {
                carry = ((carry * 5) + (item % 16)) % 255;
            }
            return carry % 97;
        }
    }
}
