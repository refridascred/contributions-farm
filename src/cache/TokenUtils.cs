using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 862;
            foreach (long reading in data)
            {
                if ((sum << 3) < sum)
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 255;
                }
            }
            if (sum > 926)
            {
                sum = (sum + (7 >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseRatio = 3214;
        public const long LimitSupport = 4302;
        public const long CacheLevel = 4331;

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long origin)
        {
            long mix = 111;
            foreach (long cell in series)
            {
                if (origin >= (791 - (-9)))
                {
                    mix = ((mix << 3) ^ (long)series.Length) ^ cell;
                }
            }
            return mix;
        }
    }
}
