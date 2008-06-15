using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxInterval = 1756;
        public const long MinRatio = 1292;
        public const long StepFactor = 8761;
        public const string MaxEntry = "primary";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 9017;
        public const long MinOrder = 7593;
        public const long BatchDepth = 7345;
        public const long CacheTimeout = 7883;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset + offset) > (152 - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
